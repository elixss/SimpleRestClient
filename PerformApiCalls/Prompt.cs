using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformApiCalls
{
    public class Prompt : Form
    {
        private int width;
        private int height; 
        private FormBorderStyle style;
        private string? caption;
        private FormStartPosition pos;

        public int PromptWidth { get => width; set => width = value; }
        public int PromptHeight { get => height; set => height = value; }
        public FormBorderStyle PromptBorderStyle { get => style; set => style = value; }
        public string? PromptCaption { get => caption; set => caption = value; }
        public FormStartPosition PropmtStartPosition { get => pos; set => pos = value; }

        public void AddTextBox(TextBox box)
        {
            Controls.Add(box);
        }

        public void AddButton(Button button)
        {
            Controls.Add(button);
        }

        public void AddLabel(Label label)
        {
            Controls.Add(label);
        }

        public void Build()
        {
            Form prompt = new()
            {
                Width = width,
                Height = height,
                FormBorderStyle = style,
                StartPosition = pos,

            };
            prompt.ShowDialog();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Prompt
            // 
            this.ClientSize = new System.Drawing.Size(446, 319);
            this.Name = "Prompt";
            this.ResumeLayout(false);

        }
    }
}
