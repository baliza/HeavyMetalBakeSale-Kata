using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IRecipeService
{
    [OperationContract]
    Recipe GetRecipe(string itemId);

    [OperationContract]
    bool SaveRecipe(Recipe item);

    [OperationContract]
    List<Recipe> GetAllRecipes();
}