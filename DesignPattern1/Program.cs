public interface IButton
{
    void render();
    void onClick();
}

public class Dialog
{
    public void render() { }
    public virtual IButton createButton () { }
}

public class WindowsButton : IButton
{
    public void onClick()
    {
        // On Click
    }

    public void render()
    {
        // Render
    }
}

public class HTMLButton : IButton
{
    public void onClick()
    {
        // On Click
    }

    public void render()
    {
        // Render
    }
}

public class WindowsDialog : Dialog
{
    public override IButton createButton()
    {
        return new WindowsButton();
    }
}

public class WebDialog : Dialog
{
    public override IButton createButton()
    {
        return new HTMLButton();
    }
}