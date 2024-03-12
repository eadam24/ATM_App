namespace ATM_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            amount_text = new Label();
            pin_text = new Label();
            user_amount = new TextBox();
            amount_error = new ErrorProvider(components);
            pin_error = new ErrorProvider(components);
            user_pin = new MaskedTextBox();
            withdraw_button = new Button();
            ((System.ComponentModel.ISupportInitialize)amount_error).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pin_error).BeginInit();
            SuspendLayout();
            // 
            // amount_text
            // 
            amount_text.AutoSize = true;
            amount_text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            amount_text.Location = new Point(62, 93);
            amount_text.Name = "amount_text";
            amount_text.Size = new Size(105, 32);
            amount_text.TabIndex = 0;
            amount_text.Text = "Amount:";
            amount_text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pin_text
            // 
            pin_text.AutoSize = true;
            pin_text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pin_text.Location = new Point(62, 189);
            pin_text.Name = "pin_text";
            pin_text.Size = new Size(56, 32);
            pin_text.TabIndex = 1;
            pin_text.Text = "PIN:";
            // 
            // user_amount
            // 
            user_amount.Location = new Point(195, 93);
            user_amount.Name = "user_amount";
            user_amount.Size = new Size(150, 31);
            user_amount.TabIndex = 2;
            // 
            // amount_error
            // 
            amount_error.ContainerControl = this;
            // 
            // pin_error
            // 
            pin_error.ContainerControl = this;
            // 
            // user_pin
            // 
            user_pin.Location = new Point(195, 190);
            user_pin.Name = "user_pin";
            user_pin.PasswordChar = '*';
            user_pin.Size = new Size(150, 31);
            user_pin.TabIndex = 4;
            // 
            // withdraw_button
            // 
            withdraw_button.Location = new Point(115, 283);
            withdraw_button.Name = "withdraw_button";
            withdraw_button.Size = new Size(287, 56);
            withdraw_button.TabIndex = 5;
            withdraw_button.Text = "Withdraw";
            withdraw_button.UseVisualStyleBackColor = true;
            withdraw_button.Click += withdraw_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 450);
            Controls.Add(withdraw_button);
            Controls.Add(user_pin);
            Controls.Add(user_amount);
            Controls.Add(pin_text);
            Controls.Add(amount_text);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)amount_error).EndInit();
            ((System.ComponentModel.ISupportInitialize)pin_error).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label amount_text;
        private Label pin_text;
        private TextBox user_amount;
        private ErrorProvider amount_error;
        private MaskedTextBox user_pin;
        private ErrorProvider pin_error;
        private Button withdraw_button;
    }
}