(function (global, undefined) {
    function confirmAspButton(button) {
        function aspButtonCallbackFn(arg) {
            if (arg) {
                __doPostBack(button.name, "");
            }
        }
        radconfirm("Are you sure you want to postback?", aspButtonCallbackFn, 330, 180, null, "Confirm");
    }

    function confirmLinkButton(button) {
        function linkButtonCallbackFn(arg) {
            if (arg) {
                //obtains a __doPostBack() with the correct UniqueID as rendered by the framework
                eval(button.href);

                //can be used in a simpler environment so that event validation is not triggered.
                //__doPostBack(button.id, "");
            }
        }
        radconfirm("Are you sure you want to postback?", linkButtonCallbackFn, 330, 180, null, "Confirm");
    }

    function confirmAspUpdatePanelPostback(button) {
        function aspUpdatePanelCallbackFn(arg) {
            if (arg) {
                __doPostBack(button.name, "");
            }
        }
        radconfirm("Are you sure you want to postback?", aspUpdatePanelCallbackFn, 330, 180, null, "Confirm");
    }

    global.confirmAspButton = confirmAspButton;
    global.confirmLinkButton = confirmLinkButton;
    global.confirmAspUpdatePanelPostback = confirmAspUpdatePanelPostback;
})(window);