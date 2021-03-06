﻿namespace Winium.StoreApps.CodedUITestProject.CommandExecutors
{
    #region

    using Winium.StoreApps.CodedUITestProject.Annotations;
    using Winium.StoreApps.Common;

    #endregion

    [UsedImplicitly]
    public class TouchDoubleTapExecutor : CommandExecutorBase
    {
        #region Methods

        protected override string DoImpl()
        {
            var registredId = this.ExecutedCommand.Parameters["element"].ToObject<string>();

            var element = this.ElementsRegistry.GetRegistredElement(registredId);
            element.DoubleClick();

            return this.JsonResponse(ResponseStatus.Success, null);
        }

        #endregion
    }
}