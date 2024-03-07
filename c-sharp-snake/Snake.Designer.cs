namespace c_sharp_snake
{
    partial class Snake
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
            snakeBlock = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)snakeBlock).BeginInit();
            SuspendLayout();
            // 
            // snakeBlock
            // 
            snakeBlock.BackColor = Color.Lime;
            snakeBlock.Location = new Point(0, 0);
            snakeBlock.Name = "snakeBlock";
            snakeBlock.Size = new Size(30, 30);
            snakeBlock.TabIndex = 0;
            snakeBlock.TabStop = false;
            // 
            // Snake
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 553);
            Controls.Add(snakeBlock);
            Name = "Snake";
            Text = "Snake";
            ((System.ComponentModel.ISupportInitialize)snakeBlock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox snakeBlock;
    }
}
