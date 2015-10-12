




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class MathLogicMath : GeneratedTest {



        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, math_logic/math.yaml, #1
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: (((4 + 2 * (r.expr(26) % 18)) / 5) - 3) */
                 var obtained = runOrCatch( r.add(4L, r.mul(2L, r.expr(26L).mod(18L))).div(5L).sub(3L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}