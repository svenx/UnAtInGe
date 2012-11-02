namespace UnAtInGeCore.Commands.Special
{
    public class TextTitel:CommandText
    {


        public override string Execute()
        {
            string s = "echo " + new string('*', this.Text.Length + 4);
            return s + Consts.NewLine + "echo * " + this.Text + " *" + Consts.NewLine + s + Consts.NewLine + "echo.";
        }
    }
}
