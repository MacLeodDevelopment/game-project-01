using Microsoft.AspNetCore.Components;

namespace Game.UI.Pages;

public class TestComponent : ComponentBase
{
    public string Something { get; set; }
    [Inject] private ISharonTest SharonTest { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Something = SharonTest.SayHello();
    }
}    
    
    
    