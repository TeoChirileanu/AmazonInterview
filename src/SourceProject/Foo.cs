using System.Collections.Generic;

namespace SourceProject
{
    /*
     identify the most popular N feature requests out of a list of feature requests
     and possible features
     out: most frequently mentioned featured
     in:
     6,
     2,
     storage, battery, hover, alexa, waterproof, solar
     7,
        I wish my kindle had even more storage,
        I wish the battery of my Kindle lasted 2 years,
        Waterproof and increased battery are my top two requests
        I read in the bath and would enjoy a waterproof Kindle
        I want to take my Kindle into the shower. Waterproof please waterproof!
        It would be neat if my Kindle would hover over my desk when not in use
        How cool would it be if charged in the sun via solar power?
     out:
     waterproof, battery
     explanation:
     'waterproof' occurs in three requests and 'battery' in two
     'hover', 'solar', 'storage' occur in only one
     */
    public class Foo
    {
        // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
        public List<string> PopularNFeatures(
            int numFeatures, // the number of possible features
            int topFeatures, // how many features to return
            List<string> possibleFeatures, // list of single words
            int numFeatureRequests,
            List<string> featureRequests) // list of sentences
        {
            var possibleFeaturesCount = possibleFeatures.Count;
            return new List<string>();
            // WRITE YOUR CODE HERE
        }
	}
}