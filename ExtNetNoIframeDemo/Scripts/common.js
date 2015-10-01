window.Utils = {};

Ext.onReady(function () {

    (function (Utils) {
        'use strict';

        Ext.Ajax.on("beforerequest", function (conn, options, eOpts) {
            Utils.mask(options.elementIdToMask);
        });
        Ext.Ajax.on("requestcomplete", function (conn, response, options, eOpts) {
            Utils.unmask(options.elementIdToMask);
        });
        Ext.Ajax.on("requestexception", function (conn, response, options, eOpts) {
            Utils.unmask(options.elementIdToMask);
        });

        Utils.navigateTo = function (action) {
            location.href = action;
        }

        Utils.mask = function (elementId, msg) {
            elementId = elementId ? elementId : 'mainContainer';
            var el = Ext.getCmp(elementId);
            el = el ? el : Ext.getBody();
            if (el.isMasked()) return;

            msg = msg || "Cargando";
            el.mask(msg)
        }

        Utils.unmask = function (elementId) {
            elementId = elementId ? elementId : 'mainContainer';
            var el = Ext.getCmp(elementId);
            el = el ? el : Ext.getBody();
            if (el.isMasked()) {
                el.unmask()
            }
        }

    })(window.Utils);

});