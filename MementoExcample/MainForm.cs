using MementoExcample.Figures;

namespace MementoExcample
{
    public partial class MainForm : Form
    {
        private readonly Originator _originator;
        private readonly Caretaker _caretaker;

        public MainForm()
        {
            InitializeComponent();
            _originator = new Originator(new PictureState());
            _caretaker = new Caretaker(_originator);
        }

        private void pbMain_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            if(rbCircle.Checked)
            {
                _originator.AddFigure(new Circle(coordinates.X, coordinates.Y));
            }
            else
            {
                _originator.AddFigure(new Square(coordinates.X, coordinates.Y));
            }

            Draw();
        }

        private void btHistory_Click(object sender, EventArgs e)
        {
            _caretaker.ShowHistory();
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            _caretaker.Backup();
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            _caretaker.Undo();
            Draw();
        }

        private void Draw()
        {
            Bitmap bitmap = new Bitmap(pbMain.Width, pbMain.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            graphics.Save();

            graphics.Clear(Color.White);

            _originator.DrawPicture(graphics);

            graphics.Save();

            pbMain.Image = bitmap;
        }
    }
}