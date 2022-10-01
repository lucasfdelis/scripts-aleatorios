function generateRandomDate(start, end) {
  const initialDate = start.getTime()
  const endDate = end.getTime()

  const randomIncrement =  Math.random() * (endDate - initialDate)

  const randomDate = new Date(initialDate + randomIncrement)
  return randomDate;
}

// Example
const startDate = new Date(2018, 0, 1) // 2018-01-01
const endDate = new Date(2022, 11, 31) // 2022-12-31

const d = generateRandomDate(startDate, endDate);
console.log(d);
