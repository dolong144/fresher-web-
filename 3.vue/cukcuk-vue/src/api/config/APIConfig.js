var APIConfig = {
    development: 'http://cukcuk.manhnv.net/',
    production: 'local:8081'
}

export default APIConfig[process.env.NODE_ENV];
// const APIConfig = {
//     development: "http://cukcuk.manhnv.net/",
//     production: "local:8081",
// };

// export default APIConfig["development"];