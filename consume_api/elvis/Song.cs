class Song{
    public int id { get;set; }
    public required string title {get; set;}
    public int artist {get; set;}
    public required string spotify{get; set;}

    public override string ToString()
    {
        return $"{id} - {title} - ({artist})\nSpotify: {spotify}";
    }


}