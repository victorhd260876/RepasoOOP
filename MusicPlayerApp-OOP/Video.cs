namespace MusicPlayerApp_OOP;

/// <summary>
/// Represents a Video.
/// OOP Concept: Inheritance. This class 'inherits' from the 'MediaItem' base class.
/// It gets the Title and Duration properties and the DisplayDetails method from MediaItem.
/// It must provide implementations for the abstract members of MediaItem (CreatorInfo, Play).
/// OOP Concept: Encapsulation. Data (Title, Artist, Album, Duration) and behavior
/// (Play, DisplayDetails) are bundled together within this class.
/// </summary>
public class Video : MediaItem // Inherits from MediaItem
{
    // Specific properties for a Song
    public string Actor { get; private set; }
    public string Formato { get; private set; }

    /// <summary>
    /// Provides the implementation for the abstract CreatorInfo property from MediaItem.
    /// </summary>
    public override string CreatorInfo => Actor; // For a song, the creator is the Artist

    /// <summary>
    /// Constructor for the Song class.
    /// It calls the base class (MediaItem) constructor using 'base(...)'.
    /// </summary>
    /// <param name="title">Title of the song.</param>
    /// <param name="artist">Artist of the song.</param>
    /// <param name="album">Album the song belongs to.</param>
    /// <param name="duration">Duration of the song.</param>
    public Video(string title, string actor, string formato, TimeSpan duration)
        : base(title, duration) // Call the base class constructor first
    {
        // Encapsulation: Internal data is protected. We use properties with private setters
        // or provide data via the constructor. Input validation happens here or in base class.
        if (string.IsNullOrWhiteSpace(actor))
            throw new ArgumentNullException(nameof(actor), "Artist cannot be empty.");

        Actor = actor;
        Actor = actor ?? "Unknown Album"; // Operador ternario: condition ?? value if true : value if false
    }

    /// <summary>
    /// OOP Concept: Polymorphism (Method Overriding).
    /// Provides the specific implementation for the 'abstract Play' method
    /// defined in the base MediaItem class.
    /// </summary>
    public override void Play()
    {
        // Simulate playing the song
        Console.WriteLine($"\n▶️ Playing Song: {Title} by {Actor}");
        Console.WriteLine($"   Medio: {Formato}, Duration: {Duration:mm\\:ss}");
    }

    /// <summary>
    /// OOP Concept: Polymorphism (Method Overriding).
    /// This method 'overrides' the 'virtual DisplayDetails' method from the base 'MediaItem' class.
    /// It first calls the base implementation and then adds song-specific details.
    /// </summary>
    public override void DisplayDetails()
    {
        base.DisplayDetails(); // Call the base class method first to display common info
        Console.WriteLine($"  Album: {Actor}"); // Add song-specific info
    }

    /// <summary>
    /// Override ToString for simpler representation when needed.
    /// </summary>
    /// <returns>Formatted string representation of the song.</returns>
    public override string ToString()
    {
        return $"{Title} - {Actor} ({Duration:mm\\:ss})";
    }
}
