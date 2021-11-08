import axios from "axios";

const url = process.env.REACT_APP_BASE_URL;

const addRateForMovie= async (data) => {
  return await axios.post(url+'/Rating', data)
};

export { addRateForMovie };