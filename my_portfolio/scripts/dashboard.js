//Function of grocery list//
$(function() {

  let $list = $('ul');
  let $newItemForm = $('#newItemForm');

  $newItemForm.on('submit', function(e) {
    e.preventDefault();
    let text = $('input[type="text"]').val();
    $list.append(`<li>${text}</li>`);
    $('input[type="text"]').val('');
  });

  $list.on('click', 'li', function() {
    let $this = $(this);
    $this.remove();
  });

});
//Function for location//  
    $list.on('click', 'li', function() {
      let $this = $(this);
      $this.remove();
    });
  
  });
  var myLocation = document.getElementById("my-coordinates")

function getLocation() {
  if(navigator.geolocation){
    navigator.geolocation.getCurrentPosition(displayPosition)
  } else {
   myLocation.innerHTML = "Not available"
  }
}

function displayPosition(position) {
  myLocation.innerHTML = "Longitude: " + position.coords.longitude + " Latitude: " + position.coords.latitude
}
//function for fidget spinner//
var data = {
  totalRevs:360, 
  totalCurrent:0, 
  totalRPS: 0
};

setInterval(goGo,1000);

function goGo() {
  data.totalRevs += data.totalRPS;
  data.totalCurrent += data.totalRPS;
  $("#wheel").css({ 'transform': 'rotate(' + data.totalRevs + 'deg)'});
  updateReport();
}

function updateReport() {
  $("#currentTotal").text(Math.floor(data.totalCurrent));
  $("#rps").text((data.totalRPS/70.4).toFixed(3));
}


$("#wheel").click(function (){
  data.totalRevs ++;
  data.totalCurrent ++;
  updateReport();
})

$(".speed").click(function (){ 
  var addVal = $(this).data( "cost" );
  if ($(this).data( "cost" ) < data.totalCurrent ) {
    data.totalCurrent -=  parseFloat($(this).data( "cost" ).toPrecision(2));
    data.totalRPS += parseFloat($(this).data( "val" ));
    $( this ).children("span").html( parseInt($( this ).children("span").html()*1.15)); 
    $( this ).data( "cost", parseInt($(this).data( "cost" ) * 1.15) ); 
  }
  updateReport();
})