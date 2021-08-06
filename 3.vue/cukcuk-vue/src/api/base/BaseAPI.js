import BaseAPIConfig from '../base/BaseAPIConfig.js';

export default class BaseAPI {

    constructor() {
        this.controller = null;
    }
    /**
     * Phương thức lấy tất cả dữ liệu
     */
    getAll() {
        return BaseAPIConfig.get(`${this.controller}`);
    }
    /**
     * Hàm lấy dữ liệu bằng id
     * @param id
     * @returns {Promise<AxiosResponse<any>>}
     */
     getById(id) {
        return BaseAPIConfig.get(`${this.controller}/${id}`);
    }

    /**
     * Hàm thêm mới dữ liệu
     * @param body
     * @returns {Promise<AxiosResponse<any>>}
     */
    add(body) {
        return BaseAPIConfig.post(`${this.controller}`, body);
    }
    /**
     * Hàm lấy dữ liệu phân trang
     * @param {*} payload 
     */
    paging(payload) {
        return BaseAPIConfig.post(`${this.controller}/paging`, payload);
    }
    /**
     * Hàm cập nhật dữ liệu
     * @param {*} id 
     * @param {*} body 
     */
    update(id, body) {
        return BaseAPIConfig.put(`${this.controller}/${id}`, body);
    }
    /**
     * Hàm xóa bản ghi
     * @param {*} id 
     */
    delete(id) {
        return BaseAPIConfig.delete(`${this.controller}/${id}`);
    }
}