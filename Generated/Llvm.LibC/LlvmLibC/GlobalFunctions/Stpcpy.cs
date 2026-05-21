using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stpcpy
{
	[MangledName("stpcpy")]
	[DemangledName("stpcpy")]
	public unsafe static void* Invoke([MangledName("dest")] void* Dest, [MangledName("src")] void* Src)
	{
		long num = 0L;
		void* ptr = null;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = Internal_string_length_char.Invoke(Src) + 1L;
			Llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = ((delegate*<void*, void*, long, void*>)Mempcpy.__pointer)(Dest, Src, num);
			void* result = ((ptr == null) ? null : ((byte*)ptr + -1));
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
