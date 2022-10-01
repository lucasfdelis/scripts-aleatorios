from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.common.exceptions import NoSuchElementException 
from time import sleep

chrome = webdriver.Chrome("./chromedriver")
chrome.get("https://suap.ifpb.edu.br/accounts/login/")
chrome.maximize_window()
sleep(2)
chrome.find_element(By.ID, "id_username").send_keys("SUA MATRICULA")
chrome.find_element(By.ID, "id_password").send_keys("SUA SENHA")

chrome.find_element(By.CLASS_NAME, "submit-row").submit()

while True:
  try:
    chrome.find_element(By.XPATH, "/html/body/div[1]/main/div[2]/div[1]/div/div/ul/li[2]/a/span").click()
    sleep(1)
    chrome.find_element(By.XPATH, "/html/body/div[1]/main/div[2]/div[1]/div/div/ul/li[2]/div/a[1]").click()
    sleep(1)
    chrome.find_element(By.XPATH, "/html/body/div[1]/aside/nav/ul[1]/li[1]/a").click()
    sleep(0.5)
    
  except NoSuchElementException:
    print("Sem notificações")
    break

