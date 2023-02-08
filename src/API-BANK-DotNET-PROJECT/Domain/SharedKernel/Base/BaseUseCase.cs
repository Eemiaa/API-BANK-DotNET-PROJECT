namespace SharedKernel.Base
{
    public abstract class BaseUseCase
    {
        protected IServiceProvider _serviceProvider;

        protected BaseUseCase(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
    }
}
