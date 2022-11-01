namespace Footballgram.Infrastructure
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Linq.Expressions;
    public static class ControllerExtensions
    {
        public static IActionResult RedirectTo<TController>(this Controller controller,
                                                  Expression<Action<TController>> expression)
        {
            if (expression.Body.NodeType != ExpressionType.Call)
            {
                throw new InvalidOperationException($"The provided expression type is not method call: {expression.Body}");
            }

            var methodCallExpression = (MethodCallExpression)expression.Body;

            var actionName = methodCallExpression.Method.Name;
            var controllerName = typeof(TController).Name.Replace(nameof(Controller), string.Empty);

            return controller.RedirectToAction(actionName, controllerName);
        }
    }
}
