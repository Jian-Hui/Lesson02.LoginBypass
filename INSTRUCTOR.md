# Lesson 02 講師備忘

## 課程目標

使用 ILSpy 找出登入流程，再使用 dnSpyEx 將 `CredentialValidator.Validate()` 修改成永遠回傳 `true`。

建議發給學員的檔案：

- `Lesson02.LoginBypass.exe`
- `Lesson02.LoginBypass.exe.config`
- `STUDENT-MISSION.txt`

請勿發放 PDB、原始碼或本文件。

## 教師測試資料

- 帳號：`operator`
- 原始密碼：`HatFactory-Lesson2-2026!`
- 通關碼：`LESSON-02-BYPASS`

密碼只供講師確認原始程式可正常登入；課堂不需要公布。

## 建議示範流程

1. 執行原始程式，輸入錯誤密碼並觀察「帳號或密碼錯誤」。
2. 在 ILSpy 搜尋該錯誤訊息，定位 `LoginForm.btnLogin_Click()`。
3. 從 `LoginService.Authenticate()` 追蹤至 `CredentialValidator.Validate()`。
4. 說明最簡單的決策點是 `Validate()` 的 `bool` 回傳值。
5. 在 dnSpyEx 對 `Validate()` 選擇 **Edit Method (C#)**。
6. 將方法內容改成 `return true;`，按 **Compile**。
7. 使用 **File > Save Module** 另存成 `Lesson02.LoginBypass.Patched.exe`。
8. 執行修改版，輸入任意非空白帳密，確認能開啟主畫面。

注意：`LoginService.Authenticate()` 會先拒絕空白欄位，所以修改 `Validate()` 後仍須輸入任意非空白密碼。這可以提醒學員控制流程中可能有不只一個判斷。

## 預期修改

```csharp
public static bool Validate(string username, string password)
{
    return true;
}
```

如果現場操作時間不足，只示範 C# 方法編輯，不講 IL 指令、Debugger、強式名稱或混淆。
