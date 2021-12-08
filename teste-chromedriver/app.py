from selenium import webdriver
import chromedriver_autoinstaller

print("oi")
chromedriver_autoinstaller.install()  # Check if the current version of chromedriver exists
print("oi 2")                                  # and if it doesn't exist, download it automatically,
                                      # then add chromedriver to path

driver = webdriver.Chrome()
driver.get("https://web.whatsapp.com")
teste = input("continuar")
driver.get("https://web.whatsapp.com/send?phone=5583988005534")
teste = input("oi")

for elem in driver.find_elements_by_xpath('.//span[@class = "N4ItZ"]'):
    print(elem.get_attribute("aria-label"))