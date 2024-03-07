public class PasswordValidator
{
    public string PasswordRequestValidator(string senha)
    {
        var errors = new List<string>();

        ValidateNotEmpty(senha, errors);
        ValidateMinimumLength(senha, errors);
        ValidateContainDigit(senha, errors);
        ValidateContainLowercaseLetter(senha, errors);
        ValidateContainUppercaseLetter(senha, errors);
        ValidateContainSpecialCharacter(senha, errors);
        ValidateNotContainRepeatedCharacters(senha, errors);

        return string.Join(Environment.NewLine, errors);
    }

    private void ValidateNotEmpty(string senha, List<string> errors)
    {
        if (string.IsNullOrEmpty(senha))
        {
            errors.Add("A senha não pode estar vazia");
        }
    }

    private void ValidateMinimumLength(string senha, List<string> errors)
    {
        if (senha.Length < 9)
        {
            errors.Add("A senha deve ter no mínimo 9 caracteres");
        }
    }

    private void ValidateContainDigit(string senha, List<string> errors)
    {
        if (!senha.Any(char.IsDigit))
        {
            errors.Add("A senha deve conter pelo menos 1 dígito");
        }
    }

    private void ValidateContainLowercaseLetter(string senha, List<string> errors)
    {
        if (!senha.Any(char.IsLower))
        {
            errors.Add("A senha deve conter pelo menos 1 letra minúscula");
        }
    }

    private void ValidateContainUppercaseLetter(string senha, List<string> errors)
    {
        if (!senha.Any(char.IsUpper))
        {
            errors.Add("A senha deve conter pelo menos 1 letra maiúscula");
        }
    }

    private void ValidateContainSpecialCharacter(string senha, List<string> errors)
    {
        if (!senha.Any(c => !char.IsLetterOrDigit(c)))
        {
            errors.Add("A senha deve conter pelo menos 1 caractere especial");
        }
    }

    private void ValidateNotContainRepeatedCharacters(string senha, List<string> errors)
    {
        if (senha.Distinct().Count() != senha.Length)
        {
            errors.Add("A senha não pode conter caracteres repetidos");
        }
    }
}
