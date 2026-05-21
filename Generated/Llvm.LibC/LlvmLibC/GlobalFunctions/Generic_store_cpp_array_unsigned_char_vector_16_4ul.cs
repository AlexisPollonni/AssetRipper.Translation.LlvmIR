using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_store_cpp_array_unsigned_char_vector_16_4ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic5storeINS_3cpp5arrayIDv16_hLm4EEEEEvPNS2_4byteET_")]
	[DemangledName("void __llvm_libc_20_1_2_::generic::store<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>>(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("value")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>")] void* Value)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 4uL; num++)
			{
				Generic_store_unsigned_char_vector_16.Invoke((byte*)Dst + num * 16L, *(InlineArray16_SByte*)Array_unsigned_char_vector_16_4ul_Index.Invoke(Value, num));
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
