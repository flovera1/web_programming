class Artist{
    public int id {get; set;}
    public required string name {get; set;}
    public override string ToString()
    {
        return $"{id} - {name}";
    }

}