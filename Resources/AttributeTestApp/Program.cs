
using Metadata;

var ClassType = typeof(Complex); //Type of the class
var attributeType = typeof(AuthorInformationAttribute); //Type of the attribute

var attribute = 
    (AuthorInformationAttribute)Attribute.GetCustomAttribute(ClassType,           
                                                             attributeType);

Console.WriteLine("Published by " + attribute.AuthorName  + " in " + attribute.YearPublished);

