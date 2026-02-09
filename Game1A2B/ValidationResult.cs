namespace Game1A2B
{
	public class ValidationResult
	{
		public bool IsSuccess { get; private set; }
		public string ErrorMessage { get; private set; }

		public static ValidationResult Success() => new ValidationResult { IsSuccess = true };
		public static ValidationResult Failure(string errorMessage) 
			=> new ValidationResult { IsSuccess = false, ErrorMessage = errorMessage };
	}
}
