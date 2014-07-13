// Type: Moq.Match
// Assembly: Moq, Version=4.2.1402.2112, Culture=neutral, PublicKeyToken=69f491c39445e920
// Assembly location: C:\Users\soccolo\Documents\GitHub\LeagueAPI\packages\Moq.4.2.1402.2112\lib\net40\Moq.dll

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace Moq
{
  /// <summary>
  /// Allows creation custom value matchers that can be used on setups and verification,
  /// 			completely replacing the built-in <see cref="T:Moq.It"/> class with your own argument
  /// 			matching rules.
  /// 
  /// </summary>
  /// 
  /// <remarks>
  /// See also <see cref="T:Moq.Match`1"/>.
  /// 
  /// </remarks>
  public abstract class Match
  {
    /// <summary>
    /// Initializes the match with the condition that
    /// 			will be checked in order to match invocation
    /// 			values.
    /// 
    /// </summary>
    /// <param name="condition">The condition to match against actual values.</param>
    /// <remarks>
    /// <seealso cref="T:Moq.Match`1"/>
    /// </remarks>
    public static T Create<T>(Predicate<T> condition);
    /// <include file="Match.xdoc" path="docs/doc[@for="Match.Create{T}(condition,renderExpression"]/*"/>
    [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
    public static T Create<T>(Predicate<T> condition, Expression<Func<T>> renderExpression);
  }
}
