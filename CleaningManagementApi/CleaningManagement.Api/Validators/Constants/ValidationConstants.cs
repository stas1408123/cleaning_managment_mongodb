namespace CleaningManagement.Api.Validators.Constants
{
    public static class ValidationConstants
    {
        public const int MinId = 0;

        public static class CleaningPlanValidationData
        {
            public const int MaxLengthName = 256;
            public const int MinLengthName = 2;
        }

        public static class AddCleaningPlanValidationData
        {
            public const int MaxLengthName = 256;
            public const int MinLengthName = 2;
        }
    }
}
