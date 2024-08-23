const listItems = document.querySelectorAll(".sidebar-list li");

listItems.forEach((item) => {
  item.addEventListener("click", () => {
    let isActive = item.classList.contains("active");

    listItems.forEach((el) => {
      el.classList.remove("active");
    });

    if (isActive) item.classList.remove("active");
    else item.classList.add("active");
  });
});

const toggleSidebar = document.querySelector(".toggle-sidebar");
const logo = document.querySelector(".logo-box");
const sidebar = document.querySelector(".sidebar");

toggleSidebar.addEventListener("click", () => {
  sidebar.classList.toggle("close");
});

logo.addEventListener("click", () => {
  sidebar.classList.toggle("close");
});


// 

const data = [
  { date: '2024-04-15', views: 1000, revenue: 500 },
  { date: '2024-04-16', views: 1500, revenue: 700 },
  { date: '2024-04-17', views: 2000, revenue: 900 }
];

// Chức năng lọc dữ liệu theo ngày đã chọn
function filterData() {
  const selectedDate = document.getElementById('date').value;
  const filteredData = data.filter(entry => entry.date === selectedDate);

  if (filteredData.length > 0) {
    const totalViews = filteredData.reduce((acc, curr) => acc + curr.views, 0);
    const totalRevenue = filteredData.reduce((acc, curr) => acc + curr.revenue, 0);

    document.getElementById('totalViews').textContent = totalViews;
    document.getElementById('totalRevenue').textContent = `$${totalRevenue}`;
  } else {
    // Nếu không tìm thấy dữ liệu cho ngày đã chọn
    document.getElementById('totalViews').textContent = 0;
    document.getElementById('totalRevenue').textContent = '$0';
    alert('No data found for the selected date.');
  }
}