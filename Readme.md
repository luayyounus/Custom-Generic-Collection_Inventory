# Generic Collections

**Author**: Luay Younus
**Version**: 1.0

## Overview
An Ecommerce store that demonstrates creating Array Add/Remove/AtIndex methods through Collection initializers. Xunit tests are written to prove the List resizing mechanism.

## Requirements to run the Application
- [Visual Studio 2017 Community with .NET Core 2.0 SDK](https://www.microsoft.com/net/core#windowscmd)
- [GitBash / Terminal](https://git-scm.com/downloads) or [GitHub Extension for Visual Studio](https://visualstudio.github.com)

## Getting Started
1. Clone the repository to your local machine.
2. Cd into the application directory where the `AppName.sln` exist.
3. Open the application using `Open/Start AppName.sln`.
4. Once Visual Studio is opened, you can Run the application by clicking on the Play button <img src="https://github.com/luayyounus/Lab02-Unit-Testing/blob/Lab02-Luay/WarCardGame/play-button.jpg" width="16"> .
5. A demo will be presented showing both C# built in Arrays Vs. custom array through Collection Initializers in Console statements.

## Inventory Explanation
###### Inventory class is implementing the custom Array method by first implementing `IEnumerable`
`public class Inventory<T> : IEnumerable<T>`

###### The class consists of the following main properties giving the Array a size of 2 for a start
```C#
public T[] Items = new T[2];
public int Count = 0;
```

###### The two required `IEnumerable` methods are implemented as the following
```C#
public IEnumerator<T> GetEnumerator()
{
    for (int i = 0; i < Count; i++)
    {
        yield return Items[i];
    }
}

IEnumerator IEnumerable.GetEnumerator()
{
    return GetEnumerator();
}
```

###### Add method implementation, increasing the Array size when more Items are added
```C#
public void Add(T item)
{
    if (Count == (Items.Length / 2))
    {
        T[] newArray = new T[Items.Length * 2];

        for (int i = 0; i < Items.Length; i++)
        {
            newArray[i] = Items[i];
        }

        Items = newArray;
    }
    Items[Count] = item;
    Count++;
}
```

###### Remove method implementation, decreasing the Array size when Items are removed
```C#
public void Remove(T item)
{
    T[] newArray = new T[Items.Length];
    if (Count - 1 <= Items.Length / 2)
    {
        newArray = new T[Items.Length / 2];
    }

    int j = 0;
    int tempCount = Count;
    for (int i = 0; i < tempCount; i++)
    {
        if (j >= tempCount) break;
        if (!item.Equals(Items[j]))
        {
            newArray[i] = Items[j];
            j++;
        }
        else
        {
            Count--;
            i--;
            j++;
        }
    }
    Items = newArray;
}
```

###### Getting Index for an Item
```C#
public int AtIndexOf(T item)
{
    for (int i = 0; i < Count; i++)
    {
        if (Items[i].Equals(item))
        {
            return i;
        }
    }
    throw new InvalidOperationException();
}
```

#### The Inventory app consists of a product class that uses a product Enum
###### Product
```C#
public class Product
{
    public string Name { get; set; }
    public ProductType Type { get; set; }

    public Product(string name, ProductType type)
    {
        Name = name;
        Type = type;
    }
}
```
###### Product Enum
```C#
public enum ProductType
{
    Movies,
    Home,
    Health,
    Grocery
}
```

#### The following are the Test Cases implemented to check different Scenarios
```C#
[Fact]
public void Return_Equal_Inventory_Count_When_Adding()
{
    // Arrange
    Product product = new Product("Computer", ProductType.Home);
    Inventory<Product> inventory = new Inventory<Product>();

    // Act
    inventory.Add(product);

    // Assert
    Assert.Equal(1, inventory.Count);
}

[Fact]
public void Return_Inventory_Half_Size_When_Removing()
{
    // Arrange
    Product product = new Product("Chair", ProductType.Home);
    Inventory<Product> inventory = new Inventory<Product>();

    // Act
    inventory.Add(product);
    inventory.Remove(product); // Resizing array to half after removing

    // Assert
    Assert.Equal(1, inventory.Items.Length);
}

[Fact]
public void Throw_Exception_When_Product_Not_Found()
{
    // Arrange
    Product product = new Product("Table", ProductType.Home);
    Inventory<Product> inventory = new Inventory<Product>();

    // Act & Assert
    Assert.Throws<InvalidOperationException>(() => inventory.AtIndexOf(product));
}
```

## Architecture
 - C# Console Core application.
 - Inventory Class that implements Add/Remove/AtIndex methods.
 - Product Class.
 - Enum for Product Types.
