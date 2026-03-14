class IfElseExercise
{
    public static void Run()
    {
        Random random = new Random();
        int daysUntilExpiration = random.Next(30);
        int discountPercentage;

        // Rule 1: Your code should only display one message.
        // Rule 2: If the user's subscription will expire in 10 days or less, display the message: Your subscription will expire soon. Renew now!
        // Rule 3: If the user's subscription will expire in 5 days or less, display the message: Your subscription will expire in a few days. Renew now and save 10%!
        // Rule 4: If the user's subscription will expire in 1 day or less, display the message: Your subscription will expire tomorrow. Renew now and save 20%!
        // Rule 5: If the user's subscription will expire in 0 days, display the message: Your subscription has expired. Renew now and save 30%!

        if (daysUntilExpiration <= 0)
        {
            discountPercentage = 30;
            Console.WriteLine($"Your subscription has expired. Renew now and save {discountPercentage}%!");
        }
        else if (daysUntilExpiration <= 1)
        {
            discountPercentage = 20;
            Console.WriteLine($"Your subscription will expire tomorrow. Renew now and save {discountPercentage}%!");
        }
        else if (daysUntilExpiration <= 5)
        {
            discountPercentage = 10;
            Console.WriteLine($"Your subscription will expire in a few days. Renew now and save {discountPercentage}%!");
        }
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }
        else
        {
            Console.WriteLine("Your subscription is active.");
        }

        Console.WriteLine($"Days until expiration: {daysUntilExpiration}");
    }
}