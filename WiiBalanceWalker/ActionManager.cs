using System;
using System.Windows.Forms;
using InputManager;

namespace WiiBalanceWalker
{
    /// <summary>Actions place holders as controls are passed after they load.</summary>
    public class ActionList
    {
        public ActionItem Left;
        public ActionItem Right;
        public ActionItem Forward;
        public ActionItem Backward;
        public ActionItem Modifier;
        public ActionItem Jump;
        public ActionItem DiagonalLeft;
        public ActionItem DiagonalRight;
    }

    /// <summary>Abstracts away selecting, saving, and sending multiple input types.</summary>
    public class ActionItem
    {
        public bool         IsActive        { get; private set; }
        string              settingName;
        string              inputText;
        int                 inputAmount;
        int                 inputType;
        Keys                inputKeys;
        Mouse.MouseKeys     inputMouseKeys;
        System.Timers.Timer inputTimer      = new System.Timers.Timer() { Interval = 2, Enabled = false };

        public ActionItem(string settingName, ComboBox controlType, NumericUpDown controlAmount)
        {
            // The name where the action should be saved.

            this.settingName = settingName;

            // Track changes to the controls.

            controlType.SelectedIndexChanged += new EventHandler(ControlType_SelectedIndexChanged);
            controlAmount.ValueChanged       += new EventHandler(ControlAmount_ValueChanged);

            // Add nothing and mouse movement options to control.

            controlType.Items.Add(new ItemWithText("",           "Do Nothing"));
            controlType.Items.Add(new ItemWithText("MouseMoveX", "Mouse Move X"));
            controlType.Items.Add(new ItemWithText("MouseMoveY", "Mouse Move Y"));

            // Add mouse button options to control.

            foreach (Mouse.MouseKeys item in Enum.GetValues(typeof(Mouse.MouseKeys)))
            {
                controlType.Items.Add(new ItemWithText(item, "Mouse Hold " + item));
            }

            // Add keyboard options to control.

            foreach (Keys item in Enum.GetValues(typeof(Keys)))
            {
                controlType.Items.Add(new ItemWithText(item, "Key " + item));
            }

            // Get the last known settings.

            inputText   = (string)Properties.Settings.Default["Action" + settingName];
            inputAmount =    (int)Properties.Settings.Default["Amount" + settingName];

            // Put the controls to the last known settings.

            controlType.Text    = inputText;
            controlAmount.Value = inputAmount;


            inputTimer.Elapsed += new System.Timers.ElapsedEventHandler(inputTimer_Elapsed);

        }

        public void ControlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Convert control generic object back into item.

            var itemWithText = (ItemWithText)((ComboBox)sender).SelectedItem;
            var itemTypeName = itemWithText.Item.GetType().Name;

            // Set the active item.

            if (itemTypeName == "Keys")
            {
                inputKeys = (Keys)itemWithText.Item;
                inputType = 1;
            }
            else if (itemTypeName == "MouseKeys")
            {
                inputType = 2;
                inputMouseKeys = (Mouse.MouseKeys)itemWithText.Item;
            }
            else if (itemTypeName == "String")
            {
                var itemText = (String)itemWithText.Item;

                if      (itemText == "")           inputType = 0;
                else if (itemText == "MouseMoveX") inputType = 3;
                else if (itemText == "MouseMoveY") inputType = 4;
            }

            // Remember settings.

            inputText = ((ComboBox)sender).Text;
            Save();
        }

        public void ControlAmount_ValueChanged(object sender, EventArgs e)
        {
            // Convert control decimal to integer and remember setting.

            inputAmount = (int)((NumericUpDown)sender).Value;
            Save();
        }

        void inputTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            switch (inputType)
            {
                case 3:
                    Mouse.MoveRelative(inputAmount, 0);
                    break;
                case 4:
                    Mouse.MoveRelative(0, inputAmount);
                    break;
            }
        }

        public void Start()
        {
            // Keyboard Keys and Mouse buttons need only to signal down then up to hold.
            // Mouse movement is incremental jumps so needs a faster repeating timer for smooth movement.

            if (this.IsActive) return;
            this.IsActive = true;

            switch (inputType)
            {
                case 0:
                    return;
                case 1:
                    Keyboard.KeyDown(inputKeys);
                    break;
                case 2:
                    Mouse.ButtonDown(inputMouseKeys);
                    break;
                case 3:
                    inputTimer.Enabled = true;
                    break;
                case 4:
                    inputTimer.Enabled = true;
                    break;
            }
        }

        public void Stop()
        {
            if (!this.IsActive) return;
            this.IsActive = false;

            switch (inputType)
            {
                case 0:
                    return;
                case 1:
                    Keyboard.KeyUp(inputKeys);
                    break;
                case 2:
                    Mouse.ButtonUp(inputMouseKeys);
                    break;
                case 3:
                    inputTimer.Enabled = false;
                    break;
                case 4:
                    inputTimer.Enabled = false;
                    break;
            }
        }

        public void Save()
        {
            Properties.Settings.Default["Action" + settingName] = inputText;
            Properties.Settings.Default["Amount" + settingName] = inputAmount;
            Properties.Settings.Default.Save();
        }
    }

    /// <summary>Used to store objects with custom text as a control item.</summary>
    public class ItemWithText
    {
        public object Item { get; private set; }
        public string Text { get; private set; }

        public ItemWithText(object item, string text)
        {
            this.Item = item;
            this.Text = text;
        }

        public override string ToString()
        {
            return this.Text;
        }
    }
}
