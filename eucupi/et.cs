IEnumerator MyCoroutine()
{
    UnityWebRequest www = UnityWebRequest.Get("https://www.example.com    yield return www.SendWebRequest();

    if (www.result == UnityWebRequest.Result.Success)
    {
        // Handle the successful response
        Debug.Log("Request successful!");
        Debug.Log(www.downloadHandler.text);
    }
    else
    {
        // Handle the error
        Debug.Log("Request failed: " + www.error);
    }
}
