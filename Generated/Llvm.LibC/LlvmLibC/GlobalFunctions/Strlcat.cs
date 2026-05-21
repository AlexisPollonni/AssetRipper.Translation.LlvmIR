using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strlcat
{
	[MangledName("strlcat")]
	[DemangledName("strlcat")]
	public unsafe static long Invoke([MangledName("dst")] void* Dst, [MangledName("src")] void* Src, [MangledName("size")] long Size)
	{
		void* ptr = null;
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = Internal_find_first_character.Invoke(Dst, 0, Size);
		unchecked
		{
			long result;
			if (ptr == null)
			{
				result = Size + Internal_string_length_char.Invoke(Src);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num);
				num = (long)ptr - (long)Dst;
				result = num + Internal_strlcpy.Invoke(ptr, Src, Size - num);
				Llvm_lifetime_end_p0.Invoke(8L, &num);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return result;
		}
	}
}
