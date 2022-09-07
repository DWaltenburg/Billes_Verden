using System.Windows.Forms;

namespace System
{
    internal class PaintEventHandler
    {
        private Action<object, PaintEventArgs> startButton_Click;

        public PaintEventHandler(Action<object, PaintEventArgs> startButton_Click)
        {
            this.startButton_Click = startButton_Click;
        }
    }
}