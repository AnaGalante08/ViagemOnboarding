using AndroidX.Lifecycle;
using ViagemOnboarding.ViewModel;

namespace ViagemOnboarding.Views;

public partial class OnboardingPage : ContentPage
{
	public OnboardingPage(OnboardingViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;

    }
}