using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class stpcpy
{
	public unsafe static void* Invoke(void* dest, void* src)
	{
		long num = 0L;
		void* ptr = null;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = internal_string_length_char.Invoke(src) + 1L;
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = ((delegate*<void*, void*, long, void*>)mempcpy.__pointer)(dest, src, num);
			void* result = ((ptr == null) ? null : ((byte*)ptr + -1));
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
