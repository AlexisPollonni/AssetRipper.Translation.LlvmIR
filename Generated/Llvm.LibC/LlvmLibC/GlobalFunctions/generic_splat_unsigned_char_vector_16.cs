using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_splat_unsigned_char_vector_16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic5splatIDv16_hEET_h")]
	[DemangledName("unsigned char vector[16] __llvm_libc_20_1_2_::generic::splat<unsigned char vector[16]>(unsigned char)")]
	[return: NativeType("unsigned char vector[16]")]
	public unsafe static InlineArray16_SByte Invoke([NativeType("unsigned char")] sbyte value)
	{
		InlineArray16_SByte inlineArray16_SByte = default(InlineArray16_SByte);
		long num = 0L;
		sbyte value2 = value;
		llvm_lifetime_start_p0.Invoke(16L, &inlineArray16_SByte);
		inlineArray16_SByte = InlineArrayHelper.Create<InlineArray16_SByte, byte>(new byte[16]
		{
			170, 170, 170, 170, 170, 170, 170, 170, 170, 170,
			170, 170, 170, 170, 170, 170
		});
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 16uL; num++)
			{
				inlineArray16_SByte = inlineArray16_SByte.InsertElement(value2, (int)num);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			InlineArray16_SByte result = inlineArray16_SByte;
			llvm_lifetime_end_p0.Invoke(16L, &inlineArray16_SByte);
			return result;
		}
	}
}
