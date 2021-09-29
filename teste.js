var jsonfile = {
    "jsonarray": [{
       "name": "Joe",
       "age": 12
    }, {
       "name": "Tom",
       "age": 14
    }]
 };
 
 var labels = jsonfile.jsonarray.map(function(e) {
    return e.name;
 });
 var data = jsonfile.jsonarray.map(function(e) {
    return e.age;
 });;
 
 var ctx = canvas.getContext('2d');
 var config = {
    type: 'line',
    data: {
       labels: labels,
       datasets: [{
          label: 'Graph Line',
          data: data,
          backgroundColor: 'rgba(0, 119, 204, 0.3)'
       }]
    }
 };
 
 var chart = new Chart(ctx, config);