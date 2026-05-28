using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Intrinsics.Unimplemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Create_file_from_fd
{
	[MangledName("_ZN19__llvm_libc_20_1_2_19create_file_from_fdEiPKc")]
	[DemangledName("__llvm_libc_20_1_2_::create_file_from_fd(int, char const*)")]
	public unsafe static Struct_yx4nca Invoke([MangledName("fd")][NativeType("int")] int Fd, [MangledName("mode")][NativeType("char const*")] void* Mode)
	{
		Cpp_optional_char_OptionalStorage cpp_optional_char_OptionalStorage = default(Cpp_optional_char_OptionalStorage);
		int num = 0;
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		int num2 = 0;
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt3 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		sbyte b = 0;
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt4 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		void* buffer = null;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt5 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		void* ptr = null;
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt6 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		Cpp_optional_int_OptionalStorage cpp_optional_int_OptionalStorage = default(Cpp_optional_int_OptionalStorage);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt7 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = File_mode_flags.Invoke(Mode);
		if (num == 0)
		{
			Unexpected_int_Constructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt, 22);
			Expected_LinuxFile_int_Constructor.Invoke(&cpp_optional_char_OptionalStorage, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0);
			goto IL_042a;
		}
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = Internal_fcntl.Invoke(Fd, 3, null);
		unchecked
		{
			if (num2 == -1)
			{
				Unexpected_int_Constructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2, 9);
				Expected_LinuxFile_int_Constructor.Invoke(&cpp_optional_char_OptionalStorage, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0);
			}
			else
			{
				if (((num2 & 3) != 0 || (num & 1) != 0) && ((num2 & 3) != 1 || (num & 2) != 0))
				{
					Llvm_lifetime_start_p0.Invoke(1L, &b);
					b = 0;
					if ((num & 4) != 0 && (num2 & 0x400) == 0)
					{
						b = 1;
						if (Internal_fcntl.Invoke(Fd, 4, (void*)(num2 | 0x400)) == -1)
						{
							Unexpected_int_Constructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt4, 9);
							Expected_LinuxFile_int_Constructor.Invoke(&cpp_optional_char_OptionalStorage, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt4.field_0);
							goto IL_0406;
						}
					}
					Llvm_lifetime_start_p0.Invoke(8L, &buffer);
					buffer = (void*)12297829382473034410uL;
					Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
					*(sbyte*)(&anon_izyfb) = -86;
					AllocChecker_Constructor.Invoke(&anon_izyfb);
					buffer = NewArray.Invoke(1024L, &anon_izyfb);
					int num3;
					if (!AllocChecker_ToBoolean.Invoke(&anon_izyfb))
					{
						Unexpected_int_Constructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt5, 12);
						Expected_LinuxFile_int_Constructor.Invoke(&cpp_optional_char_OptionalStorage, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt5.field_0);
						num3 = 1;
					}
					else
					{
						num3 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
					switch (num3)
					{
					case 0:
						{
							Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb2);
							*(sbyte*)(&anon_izyfb2) = -86;
							AllocChecker_Constructor.Invoke(&anon_izyfb2);
							Llvm_lifetime_start_p0.Invoke(8L, &ptr);
							void* ptr2 = New.Invoke(128L, &anon_izyfb2);
							nint num4;
							if (ptr2 == null)
							{
								num4 = 0;
							}
							else
							{
								LinuxFile_Constructor.Invoke((LinuxFile*)ptr2, Fd, buffer, 1024L, 0, Owned: true, num);
								num4 = (nint)ptr2;
							}
							ptr = (void*)num4;
							if (!AllocChecker_ToBoolean.Invoke(&anon_izyfb2))
							{
								Unexpected_int_Constructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt6, 12);
								Expected_LinuxFile_int_Constructor.Invoke(&cpp_optional_char_OptionalStorage, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt6.field_0);
							}
							else
							{
								if ((b & 1) == 1)
								{
									Llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_int_OptionalStorage);
									*(int*)(&cpp_optional_int_OptionalStorage) = -1431655766;
									((sbyte*)(&cpp_optional_int_OptionalStorage))[4] = -86;
									sbyte* ptr3 = (sbyte*)(&cpp_optional_int_OptionalStorage) + 5;
									*ptr3 = -86;
									ptr3[1] = -86;
									ptr3[2] = -86;
									*(InlineArray5_Byte*)(&cpp_optional_int_OptionalStorage) = NumericHelper.TruncOrZextToBytes<long, InlineArray5_Byte>(File_seek.Invoke(ptr, 0L, 2));
									if (!Expected_int_int_has_value.Invoke(&cpp_optional_int_OptionalStorage))
									{
										Free.Invoke(ptr);
										Unexpected_int_Constructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt7, *(int*)Expected_int_int_error.Invoke(&cpp_optional_int_OptionalStorage));
										Expected_LinuxFile_int_Constructor.Invoke(&cpp_optional_char_OptionalStorage, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt7.field_0);
										num3 = 1;
									}
									else
									{
										num3 = 0;
									}
									Llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_int_OptionalStorage);
									switch (num3)
									{
									case 0:
										break;
									default:
										goto IL_03d2;
									}
								}
								Expected_LinuxFile_int_Constructor.Invoke(&cpp_optional_char_OptionalStorage, (LinuxFile*)ptr);
							}
							goto IL_03d2;
						}
						IL_03d2:
						Llvm_lifetime_end_p0.Invoke(8L, &ptr);
						Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb2);
						break;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &buffer);
					goto IL_0406;
				}
				Unexpected_int_Constructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt3, 22);
				Expected_LinuxFile_int_Constructor.Invoke(&cpp_optional_char_OptionalStorage, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt3.field_0);
			}
			goto IL_0418;
		}
		IL_0418:
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		goto IL_042a;
		IL_0406:
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		goto IL_0418;
		IL_042a:
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return *unchecked((Struct_yx4nca*)(&cpp_optional_char_OptionalStorage));
	}
}
