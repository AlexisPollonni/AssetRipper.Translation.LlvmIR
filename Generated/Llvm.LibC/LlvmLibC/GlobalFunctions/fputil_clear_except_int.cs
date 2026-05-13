using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12clear_exceptEi")]
[DemangledName("__llvm_libc_20_1_2_::fputil::clear_except(int)")]
internal static partial class fputil_clear_except_int
{
	public unsafe static int Invoke(int excepts)
	{
		fputil_internal_X87StateDescriptor fputil_internal_X87StateDescriptor2 = default(fputil_internal_X87StateDescriptor);
		int num = 0;
		llvm_lifetime_start_p0.Invoke(28L, &fputil_internal_X87StateDescriptor2);
		unchecked
		{
			*(short*)(&fputil_internal_X87StateDescriptor2) = -21846;
			((short*)(&fputil_internal_X87StateDescriptor2))[1] = -21846;
			((short*)(&fputil_internal_X87StateDescriptor2))[2] = -21846;
			((short*)(&fputil_internal_X87StateDescriptor2))[3] = -21846;
			sbyte* ptr = (sbyte*)(&fputil_internal_X87StateDescriptor2) + 8;
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			((int*)ptr)[2] = -1431655766;
			((int*)ptr)[3] = -1431655766;
			((int*)ptr)[4] = -1431655766;
			fputil_internal_get_x87_state_descriptor_fputil_internal_X87StateDescriptor.Invoke(&fputil_internal_X87StateDescriptor2);
			int num2 = (ushort)(short)((ushort)fputil_internal_get_status_value_for_except_int.Invoke(excepts) ^ -1);
			short* ptr2 = &fputil_internal_X87StateDescriptor2.status_word;
			*ptr2 = (short)((ushort)(*ptr2) & num2);
			fputil_internal_write_x87_state_descriptor_fputil_internal_X87StateDescriptor_const.Invoke(&fputil_internal_X87StateDescriptor2);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fputil_internal_get_mxcsr.Invoke();
			int num3 = (ushort)fputil_internal_get_status_value_for_except_int.Invoke(excepts) ^ -1;
			num &= num3;
			fputil_internal_write_mxcsr_unsigned_int.Invoke(num);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(28L, &fputil_internal_X87StateDescriptor2);
			return 0;
		}
	}
}
