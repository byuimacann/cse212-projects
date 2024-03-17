using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    long _generated;
    string _url;
    string _title;
    string _api;
    int _count;
    int _status;
    
    int _longitudeMin;
    int _latitudeMin;
    int _depthMin;
    int _longitudeMax;
    int _latitudeMax;
    int _depthMax;

public void Metadata(long generated, string url, string title, string api, int count, int status)
{
    _generated = generated;
    _url = url;
    _title = title;
    _api = api;
    _count = count;
    _status = status;
}

public void Bbox(int longitudeMin, int latitudeMin, int depthMin, int longitudeMax, int latitudeMax, int depthMax)
{
    _longitudeMin = longitudeMin;
    _latitudeMin  = latitudeMin;
    _depthMin = depthMin;
    _longitudeMax = longitudeMax;
    _latitudeMax = latitudeMax;
    _depthMax = depthMax;
}


}