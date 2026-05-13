using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internalL22strrchr_implementationEPKci.190")]
[DemangledName("__llvm_libc_20_1_2_::internal::strrchr_implementation(char const*, int) (.190)")]
internal static partial class internal_strrchr_implementation_char_const_int_190
{
	public unsafe static void* Invoke(void* src, int c)
	{
		sbyte b = 0;
		void* ptr = null;
		void* ptr2 = src;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		unchecked
		{
			b = (sbyte)c;
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = null;
			while (true)
			{
				if (*(sbyte*)ptr2 == b)
				{
					ptr = ptr2;
				}
				if (*(sbyte*)ptr2 == 0)
				{
					break;
				}
				ptr2 = (byte*)ptr2 + 1;
			}
			void* result = ptr;
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			return result;
		}
	}
}
