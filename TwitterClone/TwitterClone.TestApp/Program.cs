
using TwitterClone.Domain.Entities;

var likeNotification = new LikeNotification(new Guid());

Console.WriteLine(likeNotification.DescribeRecord());


var tweets = new List<Tweet>
{
    new Tweet("This is a tweet.")
    {
        UserId = Guid.NewGuid()
    },
    new Tweet("This is a tweet 1.")
    {
        UserId = Guid.NewGuid()
    }
};

// Iterate through the list to print each tweet
foreach (var tweet in tweets)
{
    Console.WriteLine(tweet.DescribeRecord());
}