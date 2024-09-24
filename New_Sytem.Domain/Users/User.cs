using New_Sytem.Domain.core.BaseType;

namespace New_Sytem.Domain.Users;

public sealed class User : AggregateRoot
{
    private User(string firstName, string lastName, string email, string password)
        : base() 
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }

    private User() : base() { }
    
    public string FirstName { get; private set; } = default!;
    public string LastName { get; private set; } = default!;
    public string Email { get; private set; } = default!;
    public string Password { get; private set; } = default!;

    public static User Create(string firstName, string lastName, string email, string password)
    {
        User user = new User(firstName, lastName, email, password);

        // Raise Event.

        return user;
    }

    public void UpdateUser(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        // Raise Event.
    }

    public void UpdateEmail(string emial)
    {
        Email = emial;

        // Raise Event.
    }

    public void UpdatePassword(string password)
    {
        Password = password;

        // Raise Event.
    }
}
