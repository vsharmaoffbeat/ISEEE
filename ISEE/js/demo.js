function btnreverce(e)
	{
		alert('ok');
		 $(".flipbox").flippyReverse();
        e.preventDefault();
	}
$(function(){
	
    /*$("#btn-reverse").on("click",function(e){
        $(".flipbox").flippyReverse();
        e.preventDefault();
    });*/
        
    $("#btn-left").on("click",function(e){
        $(".flipbox").flippy({
            color_target: "red",
            direction: "left",
            duration: "1000",
            verso: "<div><span class='nbtn n_search' id='btn-reverse' onclick='btnreverce(this.event);'>Back</span></div>",
         });
         e.preventDefault();
    });
    
    $("#btn-right").on("click",function(e){
        $(".flipbox").flippy({
            color_target: "#2893B9",
            direction: "right",
            duration: "750",
            verso: "<div class='imgs'><img src='http://demos.thesoftwareguy.in/flip-effect-jquery/images/1.gif' alt='' /></div>",
         });
         e.preventDefault();
    });
    
    $("#btn-top").on("click",function(e){
        $(".flipbox").flippy({
            color_target: "#b6d635",
            direction: "top",
            duration: "750",
            verso: "<span class=\"big\">Great !</span>",
         });
         e.preventDefault();
    });
    
    $("#btn-bottom").on("click",function(e){
        $(".flipbox").flippy({
            color_target: "#03588C",
            direction: "bottom",
            duration: "750",
            verso: "<span class=\"big\">Flip !</span>",
         });
         e.preventDefault();
    });
	
	$("#retailer").on("click",function(e){
        
		 $(".flipbox2").flippy({
            color_target: "#637BAD",
            direction: "left",
            duration: "750",
            verso: $("#rt_content").html()
         });
		 
        e.preventDefault();
    });
	
	$("#wh").on("click",function(e){
        
		 $(".flipbox2").flippy({
            color_target: "#0084B4",
            direction: "right",
            duration: "750",
            verso: $("#wh_content").html()
         });
		 
        e.preventDefault();
    });
	
	$("#evnt").on("click",function(e){
        
		 $(".flipbox2").flippy({
            color_target: "red",
            direction: "right",
            duration: "750",
            verso: "<h1>Events Callback, check below</h1>",
			 onStart: function(){
                 $("#ev").append("on start called.<br>")
             },
			 onMidway: function(){
                 $("#ev").append("on midway called.<br>")
             },
			 onAnimation: function(){
                 $("#ev").append("on animation called.<br>")
             },
			 onFinish: function(){
                 $("#ev").append("on finish called.<br>")
             }
			 
         });
		 
        e.preventDefault();
    });
    
});