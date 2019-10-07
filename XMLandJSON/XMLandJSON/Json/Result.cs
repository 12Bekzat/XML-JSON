using System;
using System.Collections.Generic;
using System.Text;

namespace JsonProject
{
  public class Result
  {
    public string wrapperType { get; set; }
    public string kind { get; set; }
    public long artistId { get; set; }
    public long collectionId { get; set; }
    public long trackId { get; set; }
    public string artistName { get; set; }
    public string collectionName { get; set; }
    public string trackName { get; set; }
    public string collectionCencoredName { get; set; }
    public string trackCencoredName { get; set; }
    public string artistViewUrl { get; set; }
    public string collectionViewUrl { get; set; }
    public string trackViewUrl { get; set; }
    public string previewUrl { get; set; }
    public string atworkUrl30 { get; set; }
    public string atworkUrl60 { get; set; }
    public string atworkUrl100 { get; set; }
    public double collectionPrice { get; set; }
    public double trackPrice { get; set; }
    public DateTime releaseDate { get; set; }
    public string collectionExplicitness { get; set; }
    public string trackExplicitness { get; set; }
    public int discCount { get; set; }
    public int discNumber { get; set; }
    public int trackCount { get; set; }
    public int trackNumber { get; set; }
    public long trackTimeMilles { get; set; }
    public string country { get; set; }
    public string currency { get; set; }
    public string primaryGenreName { get; set; }
    public bool IsSteramable { get; set; }
  }
}
