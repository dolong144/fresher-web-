<template>
    <div class="content">
        <div class="nav">
            <div class="title">
                <b>Danh sách nhân viên</b>
            </div>
            <div class="top-button">
                <div class="button delete-button">
                    <div class="icon-button"></div>
                    <div class="text">
                        <p>Xoá nhân viên</p>
                    </div>
                </div>
                <div class="button add-button">
                    <div class="icon-button"></div>
                    <div class="text">
                        <p>Thêm nhân viên</p>
                    </div>
                </div>
            </div>
            
        </div>
        
        <div class="search">
            <div class="combo-search">
                <div class="search-button">
                    <div class="icon-search"></div>
                    <input type="text" class="input-box" placeholder="Tìm kiếm theo mã, Tên hoặc Số điện thoại">
                </div>
                <div class="option">
                    <div class="value">option 1</div>
                    <div class="value">option 2</div>
                </div>
            </div>
            <div class="combo-box" id="department">
                <div class="select-button">
                    <div class="title">Tất cả phòng ban</div>
                    <div class="icon-button">
                        <i class="fas fa-solid fa-chevron-down"></i>
                    </div>
                </div>
                <div class="option">
                    <!-- <div class="option">
                            <div class="value">
                                <div class="icon-active">
                                    <i class="fas fa-solid fa-check"></i>
                                </div>
                                <div>Nam</div>
                            </div>
                            <div class="value">
                                <div class="icon-active">
                                    <i class="fas fa-solid fa-check"></i>
                                </div>
                                <div>Nữ</div>
                            </div>
                        </div>-->
                <div class="value" code="142cb08f-7c31-21fa-8e90-67245e8b283e"><div class="icon-active">
                                            <i class="fas fa-solid fa-check"></i>
                                            </div>
                                            <div>Phòng Marketting</div></div><div class="value" code="17120d02-6ab5-3e43-18cb-66948daf6128"><div class="icon-active">
                                            <i class="fas fa-solid fa-check"></i>
                                            </div>
                                            <div>Phòng đào tạo</div></div><div class="value" code="469b3ece-744a-45d5-957d-e8c757976496"><div class="icon-active">
                                            <i class="fas fa-solid fa-check"></i>
                                            </div>
                                            <div>Phòng Nhân sự</div></div><div class="value" code="4e272fc4-7875-78d6-7d32-6a1673ffca7c"><div class="icon-active">
                                            <i class="fas fa-solid fa-check"></i>
                                            </div>
                                            <div>Phòng Công nghệ</div></div></div>
            </div>
            <div class="combo-box" id="position">
                <div class="select-button">
                    <div class="title">Tất cả vị trí</div>
                    <div class="icon-button">
                        <i class="fas fa-solid fa-chevron-down"></i>
                    </div>
                </div>
                <div class="option">
                    <!-- <div class="value">option</div>
                    <div class="value">option</div> -->
                <div class="value" code="30d41e52-5e66-72bc-6c1c-b47866e0b131"><div class="icon-active">
                                        <i class="fas fa-solid fa-check"></i>
                                        </div>
                                        <div>Giám đốc</div></div><div class="value" code="548dce5f-5f29-4617-725d-e2ec561b0f41"><div class="icon-active">
                                        <i class="fas fa-solid fa-check"></i>
                                        </div>
                                        <div>Nhân viên</div></div><div class="value" code="589edf01-198a-4ff5-958e-fb52fd75a1d4"><div class="icon-active">
                                        <i class="fas fa-solid fa-check"></i>
                                        </div>
                                        <div>Phó phòng</div></div><div class="value" code="5bd71cda-209f-2ade-54d1-35c781481818"><div class="icon-active">
                                        <i class="fas fa-solid fa-check"></i>
                                        </div>
                                        <div>Trưởng phòng</div></div></div>
            </div>
            <div class="textbox-default">
                <div class="refresh"></div>
            </div>
        </div>
        <div class="table">
            <table id="detailEmployee">
                <thead>
                    <tr><th></th>
                    <th>Mã nhân viên</th>
                    <th>Họ và tên</th>
                    <th>Giới tính</th>
                    <th>Ngày sinh</th>
                    <th>Điện thoại</th>
                    <th>Email</th>
                    <th>Chức vụ</th>
                    <th>Phòng ban</th>
                    <th>Mức lương cơ bản</th>
                    <th>Tình trạng công việc</th> 
                </tr></thead>
                <tbody><tr id="005d0185-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-368</td>
                        <td>Nguyễn Thủy Long</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0265353692</td>
                        <td>nhanvien.MF368@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>436.277.164</td>
                        <td>2</td>
                    </tr><tr id="0083a557-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-25</td>
                        <td>Lưu Việt Đức</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0305205933</td>
                        <td>nhanvien.MF25@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>974.034.273</td>
                        <td>1</td>
                    </tr><tr id="0084b005-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-382</td>
                        <td>Mạc Đức Tú</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0330264449</td>
                        <td>nhanvien.MF382@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>92.757.645</td>
                        <td></td>
                    </tr><tr id="0085735b-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-383</td>
                        <td>Mạc Việt Loan</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0585249332</td>
                        <td>nhanvien.MF383@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Nhân sự</td>
                        <td>654.554.815</td>
                        <td>3</td>
                    </tr><tr id="008f0834-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-384</td>
                        <td>Lý Thị Trâm</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0972641564</td>
                        <td>nhanvien.MF384@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>211.480.059</td>
                        <td>2</td>
                    </tr><tr id="008ff029-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-385</td>
                        <td>Đỗ Việt Dũng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0585324580</td>
                        <td>nhanvien.MF385@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>284.663.470</td>
                        <td>4</td>
                    </tr><tr id="00906970-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-386</td>
                        <td>Lê Hữu Khánh Ngọc</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0960542821</td>
                        <td>nhanvien.MF386@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Marketting</td>
                        <td>5.791.425</td>
                        <td>1</td>
                    </tr><tr id="0090df76-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-27</td>
                        <td>Lương Tiến Đức</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0912174466</td>
                        <td>nhanvien.MF27@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>43.243.108</td>
                        <td>4</td>
                    </tr><tr id="0091b828-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-387</td>
                        <td>Trần Thu Dũng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0525573272</td>
                        <td>nhanvien.MF387@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>844.813.738</td>
                        <td>4</td>
                    </tr><tr id="0092f8a3-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-388</td>
                        <td>Lý Văn Hường</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0226363985</td>
                        <td>nhanvien.MF388@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>357.904.694</td>
                        <td>2</td>
                    </tr><tr id="009a88b8-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-389</td>
                        <td>Trần Thị Trâm</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0545790217</td>
                        <td>nhanvien.MF389@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>374.115.077</td>
                        <td>3</td>
                    </tr><tr id="009baa67-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-390</td>
                        <td>Đậu Thị Trâm</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0139480855</td>
                        <td>nhanvien.MF390@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>364.630.704</td>
                        <td>2</td>
                    </tr><tr id="009cd682-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-391</td>
                        <td>Lưu Văn Hưng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0273089708</td>
                        <td>nhanvien.MF391@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>523.421.349</td>
                        <td>4</td>
                    </tr><tr id="009d7564-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-392</td>
                        <td>Trương Thị Hùng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0809280562</td>
                        <td>nhanvien.MF392@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>744.850.534</td>
                        <td>4</td>
                    </tr><tr id="00a108d3-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-393</td>
                        <td>Lê Hữu Khánh Lan</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0749302621</td>
                        <td>nhanvien.MF393@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Nhân sự</td>
                        <td>508.110.609</td>
                        <td></td>
                    </tr><tr id="00a5f7a9-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-394</td>
                        <td>Phạm Thủy Trâm</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0257885778</td>
                        <td>nhanvien.MF394@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>860.014.396</td>
                        <td>1</td>
                    </tr><tr id="00b3ef46-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-400</td>
                        <td>Đỗ Việt Tùng</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0285847609</td>
                        <td>nhanvien.MF400@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>541.585.723</td>
                        <td>2</td>
                    </tr><tr id="00b77d1d-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-401</td>
                        <td>Lưu Việt Tú</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0226085439</td>
                        <td>nhanvien.MF401@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Marketting</td>
                        <td>242.890.903</td>
                        <td>1</td>
                    </tr><tr id="00b7cf30-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-403</td>
                        <td>Lương Ngọc Tú</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0270975814</td>
                        <td>nhanvien.MF403@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>112.491.929</td>
                        <td>1</td>
                    </tr><tr id="00b7fa48-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-402</td>
                        <td>Võ Thủy Loan</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0454712033</td>
                        <td>nhanvien.MF402@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>233.527.386</td>
                        <td>3</td>
                    </tr><tr id="0001ca04-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-337</td>
                        <td>Lê Hữu Thu Long</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0853114237</td>
                        <td>nhanvien.MF337@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>355.432.312</td>
                        <td>3</td>
                    </tr><tr id="000315f7-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-338</td>
                        <td>Lý Việt Mạnh</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0184612121</td>
                        <td>nhanvien.MF338@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>510.135.147</td>
                        <td>2</td>
                    </tr><tr id="0006922c-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-339</td>
                        <td>Lê Hữu Việt Đức</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>05855232</td>
                        <td>nhanvien.MF339@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>419.457.644</td>
                        <td>4</td>
                    </tr><tr id="000712fa-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-13</td>
                        <td>Văn Thu Loan</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0677736415</td>
                        <td>nhanvien.MF13@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>560.876.610</td>
                        <td>3</td>
                    </tr><tr id="000d73dd-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-341</td>
                        <td>Trương Văn Loan</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0124652191</td>
                        <td>nhanvien.MF341@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>850.410.245</td>
                        <td>1</td>
                    </tr><tr id="00146ca8-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-342</td>
                        <td>Lưu Văn Hùng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0837838925</td>
                        <td>nhanvien.MF342@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>456.917.726</td>
                        <td>2</td>
                    </tr><tr id="0015631a-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-344</td>
                        <td>Hồ Ngọc Tú</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0517897627</td>
                        <td>nhanvien.MF344@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>208.335.356</td>
                        <td>2</td>
                    </tr><tr id="001568ba-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-345</td>
                        <td>Trần Thủy Tú</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0271938155</td>
                        <td>nhanvien.MF345@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>286.069.711</td>
                        <td>4</td>
                    </tr><tr id="0015bfd8-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-346</td>
                        <td>Văn Thị Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0271409999</td>
                        <td>nhanvien.MF346@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>657.155.518</td>
                        <td>3</td>
                    </tr><tr id="0015cb6e-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-343</td>
                        <td>Lương Ngọc Tú</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0771423338</td>
                        <td>nhanvien.MF343@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Nhân sự</td>
                        <td>213.397.252</td>
                        <td>1</td>
                    </tr><tr id="00190f95-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-347</td>
                        <td>Mạc Việt Đức</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0383183133</td>
                        <td>nhanvien.MF347@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>647.390.642</td>
                        <td>1</td>
                    </tr><tr id="0021afa8-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-349</td>
                        <td>Lưu Ngọc Hường</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0671255243</td>
                        <td>nhanvien.MF349@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>651.523.388</td>
                        <td>3</td>
                    </tr><tr id="0021f1f8-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-348</td>
                        <td>Võ Việt Hường</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>099905990</td>
                        <td>nhanvien.MF348@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Công nghệ</td>
                        <td>371.450.297</td>
                        <td>4</td>
                    </tr><tr id="0022030f-ed5a-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-350</td>
                        <td>Lưu undefined undefined</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0620314634</td>
                        <td>nhanvien.MF350@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>264.237.799</td>
                        <td>2</td>
                    </tr><tr id="ff8d0a3a-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-295</td>
                        <td>Văn Văn Loan</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0773695152</td>
                        <td>nhanvien.MF295@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>372.967.155</td>
                        <td>4</td>
                    </tr><tr id="ff8f7f02-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-296</td>
                        <td>Văn Đức Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>059671955</td>
                        <td>nhanvien.MF296@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Marketting</td>
                        <td>928.400.365</td>
                        <td>4</td>
                    </tr><tr id="ff914f89-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-297</td>
                        <td>Văn Ngọc Tú</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0255197639</td>
                        <td>nhanvien.MF297@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>43.262.536</td>
                        <td>4</td>
                    </tr><tr id="ff9181b1-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-299</td>
                        <td>Văn Ngọc Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0944339952</td>
                        <td>nhanvien.MF299@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Nhân sự</td>
                        <td>792.684.065</td>
                        <td>2</td>
                    </tr><tr id="ff919966-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-298</td>
                        <td>Trương Đức Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0939978076</td>
                        <td>nhanvien.MF298@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>758.748.565</td>
                        <td>4</td>
                    </tr><tr id="ff970953-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-300</td>
                        <td>Mạc Đức Huyền</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>031039514</td>
                        <td>nhanvien.MF300@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>867.708.171</td>
                        <td>4</td>
                    </tr><tr id="ff98cf7e-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-301</td>
                        <td>Đỗ Tiến Ngọc</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>035392581</td>
                        <td>nhanvien.MF301@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>50.284.298</td>
                        <td>2</td>
                    </tr><tr id="ff9b5874-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-302</td>
                        <td>Đỗ Thị Lan</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0241349872</td>
                        <td>nhanvien.MF302@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>443.737.228</td>
                        <td>4</td>
                    </tr><tr id="ff9ddda3-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-19</td>
                        <td>Võ Tiến Lan</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0420730368</td>
                        <td>nhanvien.MF19@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>126.570.733</td>
                        <td>1</td>
                    </tr><tr id="ff9dfe23-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-303</td>
                        <td>undefined Khánh Tùng</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0274677122</td>
                        <td>nhanvien.MF303@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>828.140.847</td>
                        <td>2</td>
                    </tr><tr id="ffa46b82-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-304</td>
                        <td>Lý Thủy Ngọc</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0809775871</td>
                        <td>nhanvien.MF304@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>876.115.455</td>
                        <td>1</td>
                    </tr><tr id="ffa807f9-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-306</td>
                        <td>Trần Khánh Lan</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0615456126</td>
                        <td>nhanvien.MF306@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>786.585.467</td>
                        <td>2</td>
                    </tr><tr id="ffa8bfd9-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-305</td>
                        <td>Trương Ngọc Tú</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0366597411</td>
                        <td>nhanvien.MF305@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>306.272.211</td>
                        <td>2</td>
                    </tr><tr id="ffa9d6f1-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-308</td>
                        <td>Lý undefined Hường</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0561121504</td>
                        <td>nhanvien.MF308@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>710.644.221</td>
                        <td>3</td>
                    </tr><tr id="ffaa5ac1-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-307</td>
                        <td>Phạm Khánh Hùng</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0334948079</td>
                        <td>nhanvien.MF307@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>884.019.445</td>
                        <td>1</td>
                    </tr><tr id="ffb07485-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-309</td>
                        <td>Đỗ Khánh Đức</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0295567214</td>
                        <td>nhanvien.MF309@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>59.768.904</td>
                        <td>3</td>
                    </tr><tr id="ffb16564-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-310</td>
                        <td>Nguyễn undefined Hường</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>018857081</td>
                        <td>nhanvien.MF310@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>654.345.098</td>
                        <td>3</td>
                    </tr><tr id="ffb5a3eb-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-312</td>
                        <td>Hồ Khánh Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0644258960</td>
                        <td>nhanvien.MF312@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>155.972.108</td>
                        <td>1</td>
                    </tr><tr id="ffb6e273-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-20</td>
                        <td>Trương Việt Tùng</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0647627269</td>
                        <td>nhanvien.MF20@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Nhân sự</td>
                        <td>386.466.027</td>
                        <td>2</td>
                    </tr><tr id="ffb8e84f-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-313</td>
                        <td>Phạm Việt Huyền</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0660357293</td>
                        <td>nhanvien.MF313@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>684.597.475</td>
                        <td>1</td>
                    </tr><tr id="ffbc2bbd-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-21</td>
                        <td>Lý Văn Huy</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0705171165</td>
                        <td>nhanvien.MF21@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>560.123.963</td>
                        <td>3</td>
                    </tr><tr id="ffc0d111-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-314</td>
                        <td>Lưu Khánh Hưng</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0417972948</td>
                        <td>nhanvien.MF314@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Nhân sự</td>
                        <td>64.471.166</td>
                        <td>1</td>
                    </tr><tr id="ffd13eef-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-319</td>
                        <td>Lý Văn Mạnh</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0196209094</td>
                        <td>nhanvien.MF319@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>654.001.792</td>
                        <td>1</td>
                    </tr><tr id="ffd3d5ae-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-321</td>
                        <td>Lương Thủy Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0840050863</td>
                        <td>nhanvien.MF321@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>11.189.142</td>
                        <td>4</td>
                    </tr><tr id="ffd87431-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-322</td>
                        <td>Hồ Khánh Lan</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0179780695</td>
                        <td>nhanvien.MF322@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>513.406.560</td>
                        <td>4</td>
                    </tr><tr id="ffd948da-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-323</td>
                        <td>Lê Thủy Hùng</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0371027164</td>
                        <td>nhanvien.MF323@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Nhân sự</td>
                        <td>518.782.641</td>
                        <td>3</td>
                    </tr><tr id="ffdc77e8-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-324</td>
                        <td>Võ Khánh Hùng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0832950979</td>
                        <td>nhanvien.MF324@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>662.649.383</td>
                        <td>1</td>
                    </tr><tr id="ffdfe94c-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-325</td>
                        <td>undefined Ngọc Ngọc</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0450279216</td>
                        <td>nhanvien.MF325@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>831.707.075</td>
                        <td>3</td>
                    </tr><tr id="ffe1b491-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-326</td>
                        <td>Lương Đức Lan</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>034776819</td>
                        <td>nhanvien.MF326@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>868.881.289</td>
                        <td>3</td>
                    </tr><tr id="ffe3998b-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-327</td>
                        <td>Trương Thu Loan</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0640482590</td>
                        <td>nhanvien.MF327@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>168.201.245</td>
                        <td>4</td>
                    </tr><tr id="ffe4bc42-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-328</td>
                        <td>Mạc Thủy undefined</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0179694941</td>
                        <td>nhanvien.MF328@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>671.819.749</td>
                        <td>1</td>
                    </tr><tr id="ffec5206-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-329</td>
                        <td>Lê Văn Loan</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0687803553</td>
                        <td>nhanvien.MF329@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>490.783.379</td>
                        <td>1</td>
                    </tr><tr id="fff0929c-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-330</td>
                        <td>Phạm Khánh Mạnh</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0214826332</td>
                        <td>nhanvien.MF330@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>718.721.036</td>
                        <td>4</td>
                    </tr><tr id="fff09fc3-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-331</td>
                        <td>Trương Ngọc Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0273675586</td>
                        <td>nhanvien.MF331@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>88.309.444</td>
                        <td>3</td>
                    </tr><tr id="fff43ef5-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-332</td>
                        <td>Đỗ Thu Tú</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0190235584</td>
                        <td>nhanvien.MF332@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>434.881.728</td>
                        <td>4</td>
                    </tr><tr id="fff468cb-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-333</td>
                        <td>Nguyễn Thủy Ngọc</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0463141007</td>
                        <td>nhanvien.MF333@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>496.061.405</td>
                        <td>1</td>
                    </tr><tr id="fff929e7-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-334</td>
                        <td>Lê undefined Long</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0831870494</td>
                        <td>nhanvien.MF334@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng đào tạo</td>
                        <td>559.905.261</td>
                        <td>1</td>
                    </tr><tr id="fffa897e-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-335</td>
                        <td>Lê Hữu Thị Trâm</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0275920978</td>
                        <td>nhanvien.MF335@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Nhân sự</td>
                        <td>376.401.783</td>
                        <td>2</td>
                    </tr><tr id="fffd0da7-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-336</td>
                        <td>undefined Đức Hưng</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0373878732</td>
                        <td>nhanvien.MF336@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>301.865.755</td>
                        <td>4</td>
                    </tr><tr id="fef12eeb-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-233</td>
                        <td>Văn Việt Huyền</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0818402358</td>
                        <td>nhanvien.MF233@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>273.454.640</td>
                        <td>3</td>
                    </tr><tr id="fef13ab5-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-234</td>
                        <td>Lý Tiến undefined</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0559000061</td>
                        <td>nhanvien.MF234@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Nhân sự</td>
                        <td>847.481.343</td>
                        <td>4</td>
                    </tr><tr id="fef28245-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-235</td>
                        <td>Mạc Thu Dũng</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0719344465</td>
                        <td>nhanvien.MF235@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>45.661.634</td>
                        <td>1</td>
                    </tr><tr id="fef50d67-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-236</td>
                        <td>Hồ Đức Hùng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0446177545</td>
                        <td>nhanvien.MF236@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>520.787.219</td>
                        <td>2</td>
                    </tr><tr id="fef73e51-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-14</td>
                        <td>Lý Thu Dũng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0854790455</td>
                        <td>nhanvien.MF14@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>323.811.254</td>
                        <td>3</td>
                    </tr><tr id="fef79efb-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-237</td>
                        <td>Đỗ Thu Hưng</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0717987043</td>
                        <td>nhanvien.MF237@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>324.198.122</td>
                        <td>2</td>
                    </tr><tr id="fefca1d3-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-238</td>
                        <td>Lý Tiến Tùng</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0842999709</td>
                        <td>nhanvien.MF238@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>230.907.939</td>
                        <td>4</td>
                    </tr><tr id="fefe259b-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-239</td>
                        <td>Văn Đức undefined</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0847342059</td>
                        <td>nhanvien.MF239@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>737.288.111</td>
                        <td>2</td>
                    </tr><tr id="ff00ff60-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-240</td>
                        <td>Lương undefined Tùng</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0810222676</td>
                        <td>nhanvien.MF240@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Marketting</td>
                        <td>36.462.073</td>
                        <td>2</td>
                    </tr><tr id="ff01e0ff-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-241</td>
                        <td>Lý Thủy Loan</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>021170143</td>
                        <td>nhanvien.MF241@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>701.981.139</td>
                        <td>2</td>
                    </tr><tr id="ff046eb2-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-242</td>
                        <td>Lê Tiến Lan</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0437872925</td>
                        <td>nhanvien.MF242@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Marketting</td>
                        <td>127.996.039</td>
                        <td>1</td>
                    </tr><tr id="ff07c93e-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-243</td>
                        <td>Trương Thủy Tú</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0510661954</td>
                        <td>nhanvien.MF243@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>911.773.345</td>
                        <td>1</td>
                    </tr><tr id="ff09b33e-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-244</td>
                        <td>Lê Ngọc Lan</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0138330386</td>
                        <td>nhanvien.MF244@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>69.440.269</td>
                        <td>3</td>
                    </tr><tr id="ff0c9956-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-245</td>
                        <td>Lương Đức Ngọc</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0451675004</td>
                        <td>nhanvien.MF245@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>881.454.679</td>
                        <td>1</td>
                    </tr><tr id="ff10a2bb-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-15</td>
                        <td>Lê Khánh Đức</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0593003570</td>
                        <td>nhanvien.MF15@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>202.973.617</td>
                        <td>1</td>
                    </tr><tr id="ff111abf-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-17</td>
                        <td>Lê Hữu Thu Tú</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0361957841</td>
                        <td>nhanvien.MF17@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>639.985.437</td>
                        <td>2</td>
                    </tr><tr id="ff12f074-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-246</td>
                        <td>Phạm Việt Hường</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>083569437</td>
                        <td>nhanvien.MF246@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>115.025.913</td>
                        <td>3</td>
                    </tr><tr id="ff1582a2-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-247</td>
                        <td>Mạc undefined Dũng</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0705301642</td>
                        <td>nhanvien.MF247@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>263.264.825</td>
                        <td>4</td>
                    </tr><tr id="ff16ef98-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-248</td>
                        <td>Lưu Ngọc undefined</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>019523380</td>
                        <td>nhanvien.MF248@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>607.883.781</td>
                        <td>3</td>
                    </tr><tr id="ff1826c4-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-16</td>
                        <td>Đậu Khánh Huyền</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0437130273</td>
                        <td>nhanvien.MF16@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>220.979.892</td>
                        <td>3</td>
                    </tr><tr id="ff1f1207-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-250</td>
                        <td>Trương Văn Hường</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0374216684</td>
                        <td>nhanvien.MF250@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>616.837.955</td>
                        <td>1</td>
                    </tr><tr id="ff200a29-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-249</td>
                        <td>Đỗ Việt Thu</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0387007329</td>
                        <td>nhanvien.MF249@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>784.277.506</td>
                        <td>2</td>
                    </tr><tr id="ff210e93-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-251</td>
                        <td>Phạm Ngọc Huyền</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0645678964</td>
                        <td>nhanvien.MF251@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Công nghệ</td>
                        <td>101.514.745</td>
                        <td>4</td>
                    </tr><tr id="ff23c743-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-252</td>
                        <td>Võ Tiến Lan</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0776043283</td>
                        <td>nhanvien.MF252@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>434.541.005</td>
                        <td>3</td>
                    </tr><tr id="ff24bfcb-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-253</td>
                        <td>Lê Đức Trâm</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0604808785</td>
                        <td>nhanvien.MF253@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>92.582.858</td>
                        <td>2</td>
                    </tr><tr id="ff2a5772-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-254</td>
                        <td>Trần Thủy Đức</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0420176929</td>
                        <td>nhanvien.MF254@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>915.934.132</td>
                        <td>3</td>
                    </tr><tr id="ff2c6ee6-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-255</td>
                        <td>Văn Khánh Ngọc</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0238233295</td>
                        <td>nhanvien.MF255@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>311.418.467</td>
                        <td>2</td>
                    </tr><tr id="ff2cf2a2-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-256</td>
                        <td>Lương Đức Đức</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0677555663</td>
                        <td>nhanvien.MF256@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>628.315.779</td>
                        <td>2</td>
                    </tr><tr id="ff2f7e78-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-257</td>
                        <td>Trần Việt Hùng</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0733662474</td>
                        <td>nhanvien.MF257@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>215.279.798</td>
                        <td>1</td>
                    </tr><tr id="ff35c40a-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-259</td>
                        <td>Lê Ngọc Thu</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>074557441</td>
                        <td>nhanvien.MF259@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>891.649.144</td>
                        <td>2</td>
                    </tr><tr id="ff362dd2-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-258</td>
                        <td>Phạm Ngọc Trâm</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0185534170</td>
                        <td>nhanvien.MF258@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Marketting</td>
                        <td>770.483.281</td>
                        <td>3</td>
                    </tr><tr id="ff37bf18-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-260</td>
                        <td>Lý Việt Đức</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0658973668</td>
                        <td>nhanvien.MF260@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>406.378.461</td>
                        <td>3</td>
                    </tr><tr id="ff38b5f6-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-262</td>
                        <td>Lưu Thu Trâm</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0975174950</td>
                        <td>nhanvien.MF262@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>426.793.013</td>
                        <td>2</td>
                    </tr><tr id="ff38ef63-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-261</td>
                        <td>Trương Thu Huyền</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0176113760</td>
                        <td>nhanvien.MF261@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>473.894.682</td>
                        <td>1</td>
                    </tr><tr id="ff3b12f9-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-263</td>
                        <td>Đỗ Việt Tú</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0281353667</td>
                        <td>nhanvien.MF263@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>553.755.802</td>
                        <td>3</td>
                    </tr><tr id="ff4120fe-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-264</td>
                        <td>Hồ Thủy Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0227293968</td>
                        <td>nhanvien.MF264@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>909.021.588</td>
                        <td>4</td>
                    </tr><tr id="ff4485b4-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-265</td>
                        <td>undefined Thủy Huyền</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0211002752</td>
                        <td>nhanvien.MF265@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>401.813.683</td>
                        <td>4</td>
                    </tr><tr id="ff45262b-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-266</td>
                        <td>Phạm Tiến Ngọc</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0337125462</td>
                        <td>nhanvien.MF266@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>444.463.576</td>
                        <td>1</td>
                    </tr><tr id="ff46f104-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-267</td>
                        <td>Lý undefined Thu</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0364877451</td>
                        <td>nhanvien.MF267@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Công nghệ</td>
                        <td>118.398.518</td>
                        <td>3</td>
                    </tr><tr id="ff49781b-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-268</td>
                        <td>Đỗ Thị Mạnh</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0430539774</td>
                        <td>nhanvien.MF268@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>742.481.571</td>
                        <td>4</td>
                    </tr><tr id="ff4c694c-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-269</td>
                        <td>Mạc Thu Hường</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0369953276</td>
                        <td>nhanvien.MF269@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>125.750.353</td>
                        <td>2</td>
                    </tr><tr id="ff507a82-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-270</td>
                        <td>Nguyễn Văn Loan</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0951711643</td>
                        <td>nhanvien.MF270@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>459.592.585</td>
                        <td>2</td>
                    </tr><tr id="ff51a12b-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-271</td>
                        <td>Hồ undefined Tú</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0721011696</td>
                        <td>nhanvien.MF271@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>856.240.536</td>
                        <td>2</td>
                    </tr><tr id="ff52b05f-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-272</td>
                        <td>Mạc Thủy Lan</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>077423835</td>
                        <td>nhanvien.MF272@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>468.293.070</td>
                        <td>1</td>
                    </tr><tr id="ff554b1a-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-273</td>
                        <td>Lưu Đức Tú</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0737865415</td>
                        <td>nhanvien.MF273@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>354.366.800</td>
                        <td>1</td>
                    </tr><tr id="ff57bed4-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-274</td>
                        <td>Lưu Việt undefined</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0410556761</td>
                        <td>nhanvien.MF274@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>190.823.984</td>
                        <td>3</td>
                    </tr><tr id="ff5bf33b-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-275</td>
                        <td>Lê Thu Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0331144066</td>
                        <td>nhanvien.MF275@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>373.548.910</td>
                        <td>2</td>
                    </tr><tr id="ff5c25cd-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-276</td>
                        <td>undefined Thị Hưng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0283464302</td>
                        <td>nhanvien.MF276@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>805.999.690</td>
                        <td>2</td>
                    </tr><tr id="ff5d8ff0-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-277</td>
                        <td>Đỗ Việt Long</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0861694901</td>
                        <td>nhanvien.MF277@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>213.928.733</td>
                        <td>2</td>
                    </tr><tr id="ff5e64a4-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-278</td>
                        <td>Lê undefined Long</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>045228015</td>
                        <td>nhanvien.MF278@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Marketting</td>
                        <td>379.579.040</td>
                        <td>2</td>
                    </tr><tr id="ff633f08-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-279</td>
                        <td>Nguyễn Văn Huyền</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0327995730</td>
                        <td>nhanvien.MF279@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Marketting</td>
                        <td>299.008.998</td>
                        <td>1</td>
                    </tr><tr id="ff68485a-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-280</td>
                        <td>Nguyễn Văn Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0895407197</td>
                        <td>nhanvien.MF280@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>158.827.711</td>
                        <td>3</td>
                    </tr><tr id="ff6aded7-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-282</td>
                        <td>Văn Thu Hùng</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0472651063</td>
                        <td>nhanvien.MF282@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng đào tạo</td>
                        <td>685.978.449</td>
                        <td>4</td>
                    </tr><tr id="ff6eb028-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-284</td>
                        <td>Lê Hữu Khánh Tùng</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0475509977</td>
                        <td>nhanvien.MF284@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>681.564.320</td>
                        <td>2</td>
                    </tr><tr id="ff6f423d-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-283</td>
                        <td>Lương Thủy Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0465501045</td>
                        <td>nhanvien.MF283@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Marketting</td>
                        <td>852.773.087</td>
                        <td>1</td>
                    </tr><tr id="ff73ff26-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-286</td>
                        <td>Lưu Thị Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0201411896</td>
                        <td>nhanvien.MF286@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>639.656.257</td>
                        <td>1</td>
                    </tr><tr id="ff740de6-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-285</td>
                        <td>Văn Thị Tú</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0397512292</td>
                        <td>nhanvien.MF285@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>559.978.431</td>
                        <td>4</td>
                    </tr><tr id="ff7769b8-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-287</td>
                        <td>Trương Thị Hường</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0595071105</td>
                        <td>nhanvien.MF287@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>571.609.535</td>
                        <td>2</td>
                    </tr><tr id="ff7834cf-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-288</td>
                        <td>Trương Thu Tú</td>
                        <td>Nam</td>
                        <td>07/01/2000</td>
                        <td>020219216</td>
                        <td>nhanvien.MF288@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>18.940.755</td>
                        <td></td>
                    </tr><tr id="ff79ecc9-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-289</td>
                        <td>Võ undefined Huy</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0842650223</td>
                        <td>nhanvien.MF289@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>187.932.543</td>
                        <td>2</td>
                    </tr><tr id="ff811454-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-290</td>
                        <td>Lý Ngọc Tú</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0858654</td>
                        <td>nhanvien.MF290@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>494.118.526</td>
                        <td>2</td>
                    </tr><tr id="ff8393c8-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-292</td>
                        <td>Đậu Thủy undefined</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>041399638</td>
                        <td>nhanvien.MF292@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>955.757.794</td>
                        <td>1</td>
                    </tr><tr id="ff83f732-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-291</td>
                        <td>Lê Hữu Tiến Dũng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0948499327</td>
                        <td>nhanvien.MF291@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Nhân sự</td>
                        <td>385.770.481</td>
                        <td>2</td>
                    </tr><tr id="ff849ebf-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-293</td>
                        <td>Văn Thủy Tùng</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0742587576</td>
                        <td>nhanvien.MF293@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>723.438.119</td>
                        <td>2</td>
                    </tr><tr id="ff85783d-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-294</td>
                        <td>Phạm Khánh Huy</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0260597936</td>
                        <td>nhanvien.MF294@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>621.554.798</td>
                        <td>4</td>
                    </tr><tr id="fe586268-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-174</td>
                        <td>Mạc Thủy undefined</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0128196637</td>
                        <td>nhanvien.MF174@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>646.918.586</td>
                        <td>4</td>
                    </tr><tr id="fe5bc66e-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-175</td>
                        <td>Lương Ngọc Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0652894243</td>
                        <td>nhanvien.MF175@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>907.022.977</td>
                        <td>1</td>
                    </tr><tr id="fe5d3137-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-176</td>
                        <td>Lê Hữu Ngọc Tú</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0867004117</td>
                        <td>nhanvien.MF176@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>626.969.137</td>
                        <td>3</td>
                    </tr><tr id="fe60ae40-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-177</td>
                        <td>Trương Văn Tú</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0394424929</td>
                        <td>nhanvien.MF177@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>767.635.919</td>
                        <td>2</td>
                    </tr><tr id="fe61dd92-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-178</td>
                        <td>Lương undefined Tú</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0417798895</td>
                        <td>nhanvien.MF178@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>258.090.658</td>
                        <td>3</td>
                    </tr><tr id="fe641c10-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-179</td>
                        <td>Lý Việt Hường</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0923661028</td>
                        <td>nhanvien.MF179@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng đào tạo</td>
                        <td>42.137.923</td>
                        <td>4</td>
                    </tr><tr id="fe678427-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-180</td>
                        <td>Trần Ngọc Hùng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0440033763</td>
                        <td>nhanvien.MF180@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>569.061.762</td>
                        <td>3</td>
                    </tr><tr id="fe6bcd30-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-181</td>
                        <td>Nguyễn Ngọc Long</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0874301175</td>
                        <td>nhanvien.MF181@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>520.534.231</td>
                        <td>3</td>
                    </tr><tr id="fe6dc500-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-182</td>
                        <td>Phạm Thị Kim Hằng</td>
                        <td>Nữ</td>
                        <td>26/07/2000</td>
                        <td>010983681</td>
                        <td>nhanvien.MF182@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>876.135.331</td>
                        <td></td>
                    </tr><tr id="fe6fb660-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-183</td>
                        <td>Trương Khánh Huyền</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0759463481</td>
                        <td>nhanvien.MF183@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>278.650.714</td>
                        <td>1</td>
                    </tr><tr id="fe7d2073-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-188</td>
                        <td>Lê Hữu Thu Ngọc</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0446300984</td>
                        <td>nhanvien.MF188@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>132.252.092</td>
                        <td>1</td>
                    </tr><tr id="fe7f315a-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-189</td>
                        <td>Hồ Thủy Huyền</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0920590240</td>
                        <td>nhanvien.MF189@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>28.398.384</td>
                        <td>2</td>
                    </tr><tr id="fe847fa4-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-191</td>
                        <td>Hồ Thị Hưng</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0885229667</td>
                        <td>nhanvien.MF191@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>772.102.384</td>
                        <td>3</td>
                    </tr><tr id="fe855df2-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-190</td>
                        <td>Mạc undefined Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0621427664</td>
                        <td>nhanvien.MF190@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>172.775.116</td>
                        <td>4</td>
                    </tr><tr id="fe85dfac-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-192</td>
                        <td>Lê undefined Mạnh</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0748395521</td>
                        <td>nhanvien.MF192@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>531.137.945</td>
                        <td>1</td>
                    </tr><tr id="fe88c44e-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-193</td>
                        <td>Đỗ Tiến Thu</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0314280458</td>
                        <td>nhanvien.MF193@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>140.122.952</td>
                        <td>1</td>
                    </tr><tr id="fe8b9bb4-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-194</td>
                        <td>Lê Hữu undefined Hùng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0972666519</td>
                        <td>nhanvien.MF194@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Marketting</td>
                        <td>308.566.019</td>
                        <td>4</td>
                    </tr><tr id="fe8fe943-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-195</td>
                        <td>Lương Thủy Lan</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0866538400</td>
                        <td>nhanvien.MF195@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>323.318.566</td>
                        <td>1</td>
                    </tr><tr id="fe91d183-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-196</td>
                        <td>Lưu Thị Loan</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0466367971</td>
                        <td>nhanvien.MF196@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>597.745.619</td>
                        <td>2</td>
                    </tr><tr id="fe94cfef-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-197</td>
                        <td>Mạc Đức Hưng</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0474201376</td>
                        <td>nhanvien.MF197@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>503.427.289</td>
                        <td>4</td>
                    </tr><tr id="fe972f6c-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-198</td>
                        <td>Lương Thủy Đức</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>034225071</td>
                        <td>nhanvien.MF198@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>320.609.319</td>
                        <td>2</td>
                    </tr><tr id="fe989101-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-199</td>
                        <td>Lý undefined Ngọc</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0264158865</td>
                        <td>nhanvien.MF199@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>808.454.790</td>
                        <td>1</td>
                    </tr><tr id="fe9e078c-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-201</td>
                        <td>Lưu Ngọc Huy</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0412473899</td>
                        <td>nhanvien.MF201@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>28.013.068</td>
                        <td>2</td>
                    </tr><tr id="fe9eb3eb-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-202</td>
                        <td>Lương Việt undefined</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0992867733</td>
                        <td>nhanvien.MF202@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>9.877.564</td>
                        <td>3</td>
                    </tr><tr id="fea04c40-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-203</td>
                        <td>Lý Văn Trâm</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0816555027</td>
                        <td>nhanvien.MF203@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>345.832.342</td>
                        <td>4</td>
                    </tr><tr id="fea365fe-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-204</td>
                        <td>Nguyễn undefined undefined</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0133208090</td>
                        <td>nhanvien.MF204@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>536.759.050</td>
                        <td>1</td>
                    </tr><tr id="fea82d41-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-205</td>
                        <td>Nguyễn Thị Huyền</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0474010227</td>
                        <td>nhanvien.MF205@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>277.545.906</td>
                        <td>2</td>
                    </tr><tr id="feaa0064-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-206</td>
                        <td>Trương Ngọc Tú</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0961327599</td>
                        <td>nhanvien.MF206@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>116.613.261</td>
                        <td>1</td>
                    </tr><tr id="feaa1d8f-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-207</td>
                        <td>Hồ Văn Tú</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0663283019</td>
                        <td>nhanvien.MF207@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>400.994.013</td>
                        <td>3</td>
                    </tr><tr id="feaca1c6-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-208</td>
                        <td>Đậu Thủy Lan</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0510963838</td>
                        <td>nhanvien.MF208@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>923.570.339</td>
                        <td>1</td>
                    </tr><tr id="feaf8a90-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-209</td>
                        <td>Lưu undefined Huyền</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0307747278</td>
                        <td>nhanvien.MF209@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>806.631.993</td>
                        <td>3</td>
                    </tr><tr id="feb385a4-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-210</td>
                        <td>Văn Thu Long</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0312686399</td>
                        <td>nhanvien.MF210@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>657.874.861</td>
                        <td>4</td>
                    </tr><tr id="feb78683-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-211</td>
                        <td>Phạm Văn Hùng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0704504372</td>
                        <td>nhanvien.MF211@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>504.910.352</td>
                        <td>3</td>
                    </tr><tr id="feb8460d-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-212</td>
                        <td>undefined Tiến Huy</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0135939149</td>
                        <td>nhanvien.MF212@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>788.349.563</td>
                        <td>1</td>
                    </tr><tr id="febb3916-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-214</td>
                        <td>Phạm Thu Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0501190227</td>
                        <td>nhanvien.MF214@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>178.399.720</td>
                        <td>2</td>
                    </tr><tr id="febb8477-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-213</td>
                        <td>Phạm Khánh Dũng</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0448807481</td>
                        <td>nhanvien.MF213@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>957.273.747</td>
                        <td>4</td>
                    </tr><tr id="febd91b2-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-215</td>
                        <td>Trần undefined Huyền</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0133318221</td>
                        <td>nhanvien.MF215@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>246.987.554</td>
                        <td>2</td>
                    </tr><tr id="febedc4b-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-216</td>
                        <td>Nguyễn Tiến Hưng</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0767262434</td>
                        <td>nhanvien.MF216@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>850.814.550</td>
                        <td>3</td>
                    </tr><tr id="fec3bed0-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-217</td>
                        <td>undefined Khánh Hường</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0412569841</td>
                        <td>nhanvien.MF217@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>360.395.982</td>
                        <td>3</td>
                    </tr><tr id="fec44b6b-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-218</td>
                        <td>Văn Đức Hùng</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0968403337</td>
                        <td>nhanvien.MF218@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>882.042.260</td>
                        <td>1</td>
                    </tr><tr id="fecda8d9-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-219</td>
                        <td>Mạc Tiến Lan</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0861529767</td>
                        <td>nhanvien.MF219@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>244.061</td>
                        <td>3</td>
                    </tr><tr id="fecdbbf2-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-221</td>
                        <td>Đậu Ngọc Long</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0408304829</td>
                        <td>nhanvien.MF221@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Công nghệ</td>
                        <td>238.176.210</td>
                        <td>4</td>
                    </tr><tr id="fecee2a5-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-220</td>
                        <td>Lê Hữu Khánh Trâm</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0451206102</td>
                        <td>nhanvien.MF220@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>471.218.009</td>
                        <td>4</td>
                    </tr><tr id="fecfefaa-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-223</td>
                        <td>Lưu Khánh Lan</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>036058788</td>
                        <td>nhanvien.MF223@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>169.757.140</td>
                        <td>4</td>
                    </tr><tr id="fed034be-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-222</td>
                        <td>Lương Tiến Hùng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0379282330</td>
                        <td>nhanvien.MF222@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>156.036.259</td>
                        <td>4</td>
                    </tr><tr id="fed9b2b2-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-12</td>
                        <td>Văn Việt Ngọc</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>053959123</td>
                        <td>nhanvien.MF12@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>151.355.253</td>
                        <td>4</td>
                    </tr><tr id="fed9eb9d-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-224</td>
                        <td>Lương Tiến Long</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0671300491</td>
                        <td>nhanvien.MF224@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>772.933.603</td>
                        <td>3</td>
                    </tr><tr id="fedd2f13-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-225</td>
                        <td>Lê Hữu Tiến Tú</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0949880618</td>
                        <td>nhanvien.MF225@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>321.954.400</td>
                        <td>3</td>
                    </tr><tr id="fede12ba-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-227</td>
                        <td>Hồ Thị Long</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0734994741</td>
                        <td>nhanvien.MF227@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>286.851.104</td>
                        <td>2</td>
                    </tr><tr id="fede2006-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-226</td>
                        <td>Trần Ngọc Ngọc</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0758157425</td>
                        <td>nhanvien.MF226@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>586.294.424</td>
                        <td>2</td>
                    </tr><tr id="fedf1de6-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-228</td>
                        <td>Nguyễn Ngọc Hùng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0421617960</td>
                        <td>nhanvien.MF228@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>214.374.171</td>
                        <td>3</td>
                    </tr><tr id="fee5bfa4-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-229</td>
                        <td>Lý Việt Tùng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0609967663</td>
                        <td>nhanvien.MF229@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Công nghệ</td>
                        <td>157.901.015</td>
                        <td>3</td>
                    </tr><tr id="fee5f75b-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-230</td>
                        <td>Nguyễn Đức Tú</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0778289906</td>
                        <td>nhanvien.MF230@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>668.121.289</td>
                        <td>4</td>
                    </tr><tr id="fee96eb1-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-231</td>
                        <td>Trương Ngọc Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0258627889</td>
                        <td>nhanvien.MF231@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>95.589.194</td>
                        <td>4</td>
                    </tr><tr id="feeb1f08-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-232</td>
                        <td>Hồ Tiến Loan</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0310313068</td>
                        <td>nhanvien.MF232@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>25.217.349</td>
                        <td>4</td>
                    </tr><tr id="fdc127c6-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-116</td>
                        <td>Lương Tiến Long</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0387278811</td>
                        <td>nhanvien.MF116@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>888.591.739</td>
                        <td>2</td>
                    </tr><tr id="fdc27929-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-117</td>
                        <td>Đậu Ngọc Tú</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0416829419</td>
                        <td>nhanvien.MF117@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>739.159.092</td>
                        <td>4</td>
                    </tr><tr id="fdc8a073-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-118</td>
                        <td>Đậu Thu Lan</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0517838600</td>
                        <td>nhanvien.MF118@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>864.745.148</td>
                        <td>1</td>
                    </tr><tr id="fdca73d6-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-120</td>
                        <td>Lê Tiến Huy</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0688733263</td>
                        <td>nhanvien.MF120@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Công nghệ</td>
                        <td>473.843.762</td>
                        <td>2</td>
                    </tr><tr id="fdca90fc-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-119</td>
                        <td>Lê Hữu Văn Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0152964175</td>
                        <td>nhanvien.MF119@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>950.205.640</td>
                        <td>4</td>
                    </tr><tr id="fdcd080d-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-121</td>
                        <td>Lý Việt Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>012749861</td>
                        <td>nhanvien.MF121@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>588.239.031</td>
                        <td>4</td>
                    </tr><tr id="fdcd5f5d-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-122</td>
                        <td>Văn Thị Lan</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0700537096</td>
                        <td>nhanvien.MF122@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Nhân sự</td>
                        <td>78.232.633</td>
                        <td>1</td>
                    </tr><tr id="fdce56d7-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-123</td>
                        <td>Phạm undefined Dũng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0386429632</td>
                        <td>nhanvien.MF123@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng đào tạo</td>
                        <td>752.796.951</td>
                        <td>1</td>
                    </tr><tr id="fdd5b24f-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-124</td>
                        <td>Lương Thị Tùng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0875845998</td>
                        <td>nhanvien.MF124@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>860.470.497</td>
                        <td>3</td>
                    </tr><tr id="fdd67ae1-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-125</td>
                        <td>Lương Việt Hùng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0416940806</td>
                        <td>nhanvien.MF125@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>71.728.054</td>
                        <td>4</td>
                    </tr><tr id="fdd8ba48-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-127</td>
                        <td>Lê Hữu Đức Loan</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0915811663</td>
                        <td>nhanvien.MF127@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>74.284.648</td>
                        <td>1</td>
                    </tr><tr id="fdd98716-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-126</td>
                        <td>Đậu undefined Huy</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0210249326</td>
                        <td>nhanvien.MF126@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>989.850.561</td>
                        <td>2</td>
                    </tr><tr id="fdda3ff2-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-128</td>
                        <td>Phạm Văn Tùng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0923882236</td>
                        <td>nhanvien.MF128@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>344.445.833</td>
                        <td>3</td>
                    </tr><tr id="fde0e603-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-129</td>
                        <td>Võ Việt Hưng</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0991639106</td>
                        <td>nhanvien.MF129@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>497.328.501</td>
                        <td>1</td>
                    </tr><tr id="fde204e4-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-130</td>
                        <td>Nguyễn Khánh Thu</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>032226357</td>
                        <td>nhanvien.MF130@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>888.980.775</td>
                        <td>4</td>
                    </tr><tr id="fde462ce-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-131</td>
                        <td>Lê Đức Ngọc</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0504562884</td>
                        <td>nhanvien.MF131@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>749.521.665</td>
                        <td>1</td>
                    </tr><tr id="fde61da7-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-132</td>
                        <td>undefined Thu Thu</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>077400617</td>
                        <td>nhanvien.MF132@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>679.741.329</td>
                        <td>2</td>
                    </tr><tr id="fdeb4199-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-133</td>
                        <td>Võ Việt Long</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>047952126</td>
                        <td>nhanvien.MF133@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>331.291.855</td>
                        <td>3</td>
                    </tr><tr id="fdeb450f-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-134</td>
                        <td>Đỗ Việt Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0499507836</td>
                        <td>nhanvien.MF134@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Nhân sự</td>
                        <td>19.447.047</td>
                        <td>4</td>
                    </tr><tr id="fdec2a12-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-135</td>
                        <td>Lê Ngọc Hùng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0738583118</td>
                        <td>nhanvien.MF135@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>257.511.743</td>
                        <td>4</td>
                    </tr><tr id="fdedf210-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-136</td>
                        <td>Lương Thị Tú</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0860578569</td>
                        <td>nhanvien.MF136@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>74.773.007</td>
                        <td>1</td>
                    </tr><tr id="fdf164d9-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-137</td>
                        <td>undefined Ngọc Ngọc</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0118694482</td>
                        <td>nhanvien.MF137@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Marketting</td>
                        <td>665.676.795</td>
                        <td>4</td>
                    </tr><tr id="fdf27e07-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-138</td>
                        <td>Hồ Văn Đức</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0385839461</td>
                        <td>nhanvien.MF138@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>888.910.072</td>
                        <td>1</td>
                    </tr><tr id="fdf73d3d-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-139</td>
                        <td>Lê Thị Loan</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0597341026</td>
                        <td>nhanvien.MF139@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>5.167.779</td>
                        <td>2</td>
                    </tr><tr id="fdf98b4f-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-140</td>
                        <td>Lê Hữu Việt undefined</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0593280596</td>
                        <td>nhanvien.MF140@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>167.683.212</td>
                        <td>2</td>
                    </tr><tr id="fdfd8419-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-142</td>
                        <td>Lý Thu Ngọc</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0892236142</td>
                        <td>nhanvien.MF142@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Marketting</td>
                        <td>308.359.171</td>
                        <td>3</td>
                    </tr><tr id="fdfdee79-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-141</td>
                        <td>Đỗ Tiến undefined</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0820685030</td>
                        <td>nhanvien.MF141@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>207.285.274</td>
                        <td>2</td>
                    </tr><tr id="fdfed6ec-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-143</td>
                        <td>Đậu Thủy Dũng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0973143225</td>
                        <td>nhanvien.MF143@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>982.754.943</td>
                        <td>4</td>
                    </tr><tr id="fe02c188-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-144</td>
                        <td>Phạm undefined Huyền</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0527505041</td>
                        <td>nhanvien.MF144@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>772.276.335</td>
                        <td>2</td>
                    </tr><tr id="fe052161-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-145</td>
                        <td>Mạc Tiến Lan</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0869696522</td>
                        <td>nhanvien.MF145@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>528.606.709</td>
                        <td>3</td>
                    </tr><tr id="fe07122a-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-146</td>
                        <td>Văn Văn Trâm</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>024324954</td>
                        <td>nhanvien.MF146@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>306.142</td>
                        <td>3</td>
                    </tr><tr id="fe0958fb-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-7</td>
                        <td>Đậu Việt Tú</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0307396503</td>
                        <td>nhanvien.MF7@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>655.613.651</td>
                        <td>4</td>
                    </tr><tr id="fe0aba13-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-147</td>
                        <td>Hồ Đức Đức</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0221070494</td>
                        <td>nhanvien.MF147@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>286.159.285</td>
                        <td>3</td>
                    </tr><tr id="fe0dd32f-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-148</td>
                        <td>Mạc Thị Đức</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0934710750</td>
                        <td>nhanvien.MF148@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>660.630.484</td>
                        <td>1</td>
                    </tr><tr id="fe0f9373-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-149</td>
                        <td>Trương Đức Mạnh</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0258963443</td>
                        <td>nhanvien.MF149@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>517.694.673</td>
                        <td>3</td>
                    </tr><tr id="fe10e4f8-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-150</td>
                        <td>Lương Khánh Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0338924266</td>
                        <td>nhanvien.MF150@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Công nghệ</td>
                        <td>8.959.790</td>
                        <td>3</td>
                    </tr><tr id="fe14f6a2-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-1</td>
                        <td>Trương Văn Thu</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0331179499</td>
                        <td>nhanvien.MF1@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>643.940.749</td>
                        <td>1</td>
                    </tr><tr id="fe16bc8e-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-151</td>
                        <td>Lê Hữu Ngọc Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0181504256</td>
                        <td>nhanvien.MF151@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>263.284.052</td>
                        <td>4</td>
                    </tr><tr id="fe194463-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-152</td>
                        <td>Lương Văn Loan</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0875868455</td>
                        <td>nhanvien.MF152@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>105.395.448</td>
                        <td>4</td>
                    </tr><tr id="fe1db5c9-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-153</td>
                        <td>Phạm Thủy Long</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>081225744</td>
                        <td>nhanvien.MF153@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>695.071.684</td>
                        <td>2</td>
                    </tr><tr id="fe20a68d-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-154</td>
                        <td>Đậu Đức undefined</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0954475042</td>
                        <td>nhanvien.MF154@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng đào tạo</td>
                        <td>488.819.692</td>
                        <td>1</td>
                    </tr><tr id="fe23a091-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-156</td>
                        <td>Phạm Thị Hường</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0955100490</td>
                        <td>nhanvien.MF156@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Marketting</td>
                        <td>523.326.117</td>
                        <td>4</td>
                    </tr><tr id="fe23d580-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-155</td>
                        <td>Văn Thủy Dũng</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0333826972</td>
                        <td>nhanvien.MF155@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng Nhân sự</td>
                        <td>927.734.254</td>
                        <td>3</td>
                    </tr><tr id="fe24c6a5-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-157</td>
                        <td>Trương Tiến Huy</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>081641143</td>
                        <td>nhanvien.MF157@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>9.613.360</td>
                        <td>2</td>
                    </tr><tr id="fe252bb5-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-158</td>
                        <td>Phạm Việt Ngọc</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>040884445</td>
                        <td>nhanvien.MF158@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>66.598.185</td>
                        <td>1</td>
                    </tr><tr id="fe2967dd-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-159</td>
                        <td>Lương Khánh undefined</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0597615719</td>
                        <td>nhanvien.MF159@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>367.376.741</td>
                        <td>2</td>
                    </tr><tr id="fe2c81d6-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-160</td>
                        <td>Lưu Khánh Lan</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0885125763</td>
                        <td>nhanvien.MF160@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>669.118.975</td>
                        <td>3</td>
                    </tr><tr id="fe306561-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-162</td>
                        <td>Nguyễn Thủy Lan</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>071560348</td>
                        <td>nhanvien.MF162@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Marketting</td>
                        <td>495.026.250</td>
                        <td>3</td>
                    </tr><tr id="fe3524db-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-163</td>
                        <td>Lê Hữu Việt undefined</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0121141514</td>
                        <td>nhanvien.MF163@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>632.468.625</td>
                        <td>3</td>
                    </tr><tr id="fe369c84-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-164</td>
                        <td>Văn Ngọc Tùng</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0222460705</td>
                        <td>nhanvien.MF164@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Marketting</td>
                        <td>927.442.085</td>
                        <td>4</td>
                    </tr><tr id="fe388f4a-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-165</td>
                        <td>undefined Thủy Tú</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0747656913</td>
                        <td>nhanvien.MF165@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng đào tạo</td>
                        <td>707.068.100</td>
                        <td>3</td>
                    </tr><tr id="fe3ca661-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-166</td>
                        <td>Lê undefined Thu</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0480586921</td>
                        <td>nhanvien.MF166@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng đào tạo</td>
                        <td>857.368.403</td>
                        <td>1</td>
                    </tr><tr id="fe3dae6c-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-167</td>
                        <td>Lý Tiến Đức</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0761305754</td>
                        <td>nhanvien.MF167@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>258.041.727</td>
                        <td>3</td>
                    </tr><tr id="fe40bea2-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-168</td>
                        <td>Lê Khánh Mạnh</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0284675830</td>
                        <td>nhanvien.MF168@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>925.503.810</td>
                        <td>3</td>
                    </tr><tr id="fe435ab0-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-169</td>
                        <td>Hồ Tiến Thu</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0736019297</td>
                        <td>nhanvien.MF169@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>677.313.400</td>
                        <td>2</td>
                    </tr><tr id="fe448348-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-170</td>
                        <td>Nguyễn Việt undefined</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0198729930</td>
                        <td>nhanvien.MF170@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>545.555.969</td>
                        <td>4</td>
                    </tr><tr id="fe47e965-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-8</td>
                        <td>Lưu undefined Trâm</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0768169405</td>
                        <td>nhanvien.MF8@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng đào tạo</td>
                        <td>282.021.889</td>
                        <td>3</td>
                    </tr><tr id="fe49a4db-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-171</td>
                        <td>Võ Thu Tùng</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0684270399</td>
                        <td>nhanvien.MF171@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Marketting</td>
                        <td>657.145.960</td>
                        <td>2</td>
                    </tr><tr id="fe49a55c-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-172</td>
                        <td>Lý undefined Mạnh</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0137958352</td>
                        <td>nhanvien.MF172@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>131.975.869</td>
                        <td>1</td>
                    </tr><tr id="fe4cc7b0-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-173</td>
                        <td>Võ Thị Mạnh</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0993031830</td>
                        <td>nhanvien.MF173@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>507.297.854</td>
                        <td>4</td>
                    </tr><tr id="fe501458-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-11</td>
                        <td>undefined Ngọc Lan</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0217478020</td>
                        <td>nhanvien.MF11@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>5.101.230</td>
                        <td>1</td>
                    </tr><tr id="fe53fb56-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-10</td>
                        <td>Trương Văn Mạnh</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>031452178</td>
                        <td>nhanvien.MF10@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Marketting</td>
                        <td>957.604.563</td>
                        <td>2</td>
                    </tr><tr id="fe55a182-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-9</td>
                        <td>undefined undefined Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0365489627</td>
                        <td>nhanvien.MF9@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>652.542.661</td>
                        <td>2</td>
                    </tr><tr id="fd30c62c-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-65</td>
                        <td>Hồ Thị Long</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0986622884</td>
                        <td>nhanvien.MF65@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>303.441.979</td>
                        <td>4</td>
                    </tr><tr id="fd315d94-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-63</td>
                        <td>Phạm Khánh undefined</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0992409303</td>
                        <td>nhanvien.MF63@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>856.128.995</td>
                        <td>1</td>
                    </tr><tr id="fd31621f-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-66</td>
                        <td>Nguyễn Việt Huyền</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0340360021</td>
                        <td>nhanvien.MF66@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>145.738.388</td>
                        <td>1</td>
                    </tr><tr id="fd3171ed-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-61</td>
                        <td>Võ Thủy Tú</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0853072464</td>
                        <td>nhanvien.MF61@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng đào tạo</td>
                        <td>549.317.965</td>
                        <td>2</td>
                    </tr><tr id="fd438b0d-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-69</td>
                        <td>Mạc Việt Huy</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>029967243</td>
                        <td>nhanvien.MF69@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Nhân sự</td>
                        <td>610.618.216</td>
                        <td>3</td>
                    </tr><tr id="fd43981f-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-68</td>
                        <td>Lê Đức Đức</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0521757817</td>
                        <td>nhanvien.MF68@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>13.768.882</td>
                        <td>1</td>
                    </tr><tr id="fd43cb09-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-70</td>
                        <td>Đỗ Thị Đức</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0712857345</td>
                        <td>nhanvien.MF70@misa.cukcuk.vn</td>
                        <td>Phó phòng</td>
                        <td>Phòng Marketting</td>
                        <td>873.073.396</td>
                        <td>3</td>
                    </tr><tr id="fd443398-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-71</td>
                        <td>Lưu Đức Mạnh</td>
                        <td></td>
                        <td>08/01/2000</td>
                        <td>0320504451</td>
                        <td>nhanvien.MF71@misa.cukcuk.vn</td>
                        <td>Nhân viên</td>
                        <td>Phòng đào tạo</td>
                        <td>588.029.279</td>
                        <td>4</td>
                    </tr><tr id="fd4e1066-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-73</td>
                        <td>Lưu Thủy Hường</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0758287443</td>
                        <td>nhanvien.MF73@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Công nghệ</td>
                        <td>987.058.656</td>
                        <td>1</td>
                    </tr><tr id="fd58974a-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-78</td>
                        <td>undefined Đức Tùng</td>
                        <td>Không xác định</td>
                        <td>08/01/2000</td>
                        <td>0311723678</td>
                        <td>nhanvien.MF78@misa.cukcuk.vn</td>
                        <td>Giám đốc</td>
                        <td>Phòng Nhân sự</td>
                        <td>22.084.190</td>
                        <td>4</td>
                    </tr><tr id="fd5c4384-ed59-11eb-94eb-42010a8c0002">
                        <td class="check-box-delete"><input type="checkbox"></td>
                        <td>NV-79</td>
                        <td>Phạm Thị Đức</td>
                        <td>Nam</td>
                        <td>08/01/2000</td>
                        <td>0134832922</td>
                        <td>nhanvien.MF79@misa.cukcuk.vn</td>
                        <td>Trưởng phòng</td>
                        <td>Phòng Công nghệ</td>
                        <td>731.498.585</td>
                        <td>1</td>
                    </tr></tbody>
            </table>
        </div>
        
        <div class="footer">
            <div class="number">Hiển thị 1-10/1000 nhân viên</div>
            <div class="page">
                <div class="first-page"></div>
                <div class="prev-page"></div>
                <div class="page-number active">1</div>
                <div class="page-number">2</div>
                <div class="page-number">3</div>
                <div class="page-number">4</div>
                <div class="next-page"></div>
                <div class="last-page"></div>
            </div>
            <div class="acount">10 nhân viên/trang</div>
        </div>
    </div>
</template>
<script>
export default {
  name: 'TheContent',
  
}
</script>
<style scoped>
@import url('../../css/layout/content.css');
@import url('../../css/main.css');
@import url('../../css/base/button.css');
@import url('../../css/base/popup.css');
@import url('../../css/base/textbox.css');
@import url('../../css/base/toast.css');
@import url('../../css/base/tooltip.css');
</style>