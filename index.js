import useFetch from "react-fetch-hook"

const {data} = useFetch("https://randomuser.me/api/");
console.log(data);