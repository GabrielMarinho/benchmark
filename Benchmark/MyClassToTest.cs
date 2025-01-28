using BenchmarkDotNet.Attributes;

public class MyClassToTest {

    private const string MyMessage = "Hello World!";
    
    public async Task<string> MyMethodWithAwaitAsync() {
        return await Task.FromResult(MyMessage);
    }
	
    public Task<string> MyMethodWithoutAwaitAsync() {
        return Task.FromResult(MyMessage);
    }
	
    [Benchmark]
    public async Task<string> ReturnWithAwaitAsync() => await MyMethodWithAwaitAsync();
	
    [Benchmark]
    public Task<string> ReturnWithoutAwaitAsync() => MyMethodWithoutAwaitAsync();
	
}