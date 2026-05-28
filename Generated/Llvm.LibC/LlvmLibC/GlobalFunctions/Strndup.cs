using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strndup
{
	[MangledName("strndup")]
	[DemangledName("strndup")]
	public unsafe static void* Invoke([MangledName("src")] void* Src, [MangledName("size")] long Size)
	{
		long num = 0L;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		void* ptr = null;
		unchecked
		{
			void* result;
			if (Src == null)
			{
				result = null;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num);
				num = Internal_string_length_char.Invoke(Src);
				if ((ulong)num > (ulong)Size)
				{
					num = Size;
				}
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
				*(sbyte*)(&anon_izyfb) = -86;
				AllocChecker_Constructor.Invoke(&anon_izyfb);
				Llvm_lifetime_start_p0.Invoke(8L, &ptr);
				ptr = NewArray.Invoke(num + 1L, &anon_izyfb);
				if (!AllocChecker_ToBoolean.Invoke(&anon_izyfb))
				{
					result = null;
				}
				else
				{
					Inline_memcpy.Invoke(ptr, Src, num + 1L);
					((sbyte*)ptr)[num] = 0;
					result = ptr;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &ptr);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
				Llvm_lifetime_end_p0.Invoke(8L, &num);
			}
			return result;
		}
	}
}
