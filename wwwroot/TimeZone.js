window.GetBroswerTimeZone = {
    Get: function seconds_with_leading_zeros(dt) 
    {
        var a = new Date().getTimezoneOffset();
        var res = -Math.round(a / 60) + ':' + -(a % 60);
        res = res < 0 ? res : res;
        return res;
    }
};