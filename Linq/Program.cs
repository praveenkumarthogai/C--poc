using System;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinqUsingMethodSyntax linqUsingMethodSyntax = new LinqUsingMethodSyntax();
            //Console.WriteLine("UsingWhere", linqUsingMethodSyntax.UsingWhere());
            //Console.WriteLine("UsingWhereAndSelect", linqUsingMethodSyntax.UsingWhereAndSelect());
            //Console.WriteLine("UsingOrderBy", linqUsingMethodSyntax.UsingOrderBy());
            //Console.WriteLine("UsingThenBy", linqUsingMethodSyntax.UsingThenBy());
            //Console.WriteLine("UsingCount", linqUsingMethodSyntax.UsingCount());
            //Console.WriteLine("UsingCountWithoutExplicitWhere", linqUsingMethodSyntax.UsingCountWithoutExplicitWhere());

            //var result  = linqUsingMethodSyntax.UsingFirstOrDefault();
            //var result1  = linqUsingMethodSyntax.UsingFirstOrDefaultUsingCondition();
            //var result2 = linqUsingMethodSyntax.UsingFirstWithCondition();


            LinqUsingMethodSyntax_PartTwo linqUsingMethodSyntax_PartTwo = new LinqUsingMethodSyntax_PartTwo();
            //var result = linqUsingMethodSyntax_PartTwo.UsingDistinct();
            //linqUsingMethodSyntax_PartTwo.SelectMany();
            //linqUsingMethodSyntax_PartTwo.UsingUnion();
            linqUsingMethodSyntax_PartTwo.UsingJoin();

        }
    }
}
