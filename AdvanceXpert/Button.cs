/**********************************************************************
*Delegates and Events Code Example                                   *
**********************************************************************/
namespace AdvanceXpert;

public delegate void EventHandler(object sender, EventArgs e);

public class Button
{
    public event EventHandler Click;

    public void OnClick()
    {
        Click?.Invoke(this, EventArgs.Empty);
    }
}
