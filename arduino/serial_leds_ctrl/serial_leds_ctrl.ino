/**
 * @file        serial_leds_ctrl.ino
 * @brief       LED Controller
 * @author      Keitetsu
 * @date        2021/09/27
 * @copyright   Copyright (c) 2021 Keitetsu
 * @par         License
 *              This software is released under the MIT License.
 */

#define LED_NUM 3 /**< LEDの数 */
/**
 * @brief       シリアル通信の受信バッファのサイズ
 */
#define SERIAL_RX_BUF_SIZE (1 + LED_NUM + 1)

/**
 * @brief       LEDの接続ピン
 */
uint8_t leds_pin[LED_NUM] = {
    2, 3, 4};

/**
 * @brief       セットアップ関数
 */
void setup()
{
    uint8_t i;

    // LEDの初期化
    for (i = 0; i < LED_NUM; i++)
    {
        pinMode(leds_pin[i], OUTPUT);
        // LOW: 点灯, HIGH: 消灯
        digitalWrite(leds_pin[i], LOW);
    }

    // シリアル通信の初期化
    Serial.begin(9600);
}

/**
 * @brief       ループ関数
 */
void loop()
{
    uint8_t rx_buf[SERIAL_RX_BUF_SIZE];
    uint8_t i;

    // シリアル通信の受信処理
    if (Serial.available() >= SERIAL_RX_BUF_SIZE)
    {
        Serial.readBytes(rx_buf, SERIAL_RX_BUF_SIZE);
        if ((rx_buf[0] == 'L') && (rx_buf[LED_NUM + 1] == '\n'))
        {
            for (i = 0; i < LED_NUM; i++)
            {
                // 1 -> LOW: 点灯, 0 -> HIGH: 消灯
                digitalWrite(leds_pin[i], (rx_buf[i + 1] == '1') ? LOW : HIGH);
            }
        }
    }
}
