function distanceOverTime(arr){
    let v1 = arr[0];
    let v2 = arr[1];
    let time = arr[2];

    let distanceFirst = (v1 / 3.6) * time;
    let distanceSecond = (v2 / 3.6) * time;

    let distance = Math.abs(distanceFirst - distanceSecond);
    console.log(distance);
}